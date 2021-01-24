using System;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents an SQL function call expression term.
    /// </summary>
    public sealed class FunctionCall : IExpression
    {
        #region Fields

        private string m_name;

        private ExpressionItem m_expressionArguments;

        private bool m_distinct = false;

        private bool m_star = false;

        #endregion

        #region Constructor

        public FunctionCall(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            m_name = name;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Called function name (never null).
        /// </summary>
        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_name = value;
            }
        }

        /// <summary>
        /// Called function arguments, or null.
        /// </summary>
        public ExpressionItem ExpressionArguments
        {
            get { return m_expressionArguments; }
            set { m_expressionArguments = value; }
        }

        public bool Distinct
        {
            get { return m_distinct; }
            set { m_distinct = value; }
        }

        public Wildcard Star
        {
            get
            {
                return m_star ? Wildcard.Value : null;
            }

            set
            {
                m_star = value != null;
            }
        }

        public bool IsComposed
        {
            get
            {
                return false; // has its own brackets
            }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            FunctionCall functionCall = new FunctionCall(m_name);

            if (m_expressionArguments != null)
            {
                functionCall.ExpressionArguments =
                    (ExpressionItem)(m_expressionArguments.Clone());
            }

            functionCall.Distinct = m_distinct;

            if (m_star)
            {
                functionCall.Star = Wildcard.Value;
            }

            return functionCall;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);

            if (m_star)
            {
                if (m_expressionArguments != null)
                {
                    throw new InvalidOperationException(
                        "Wildcard argument cannot be combined with expression.");
                }
                if (visitor is MSqlServerTailor)
                {  /*Added by Kunal*/
                    MSqlServerTailor trailor = visitor as MSqlServerTailor;
                    if (trailor.queryParts.ParsingState == ParsingState.COLUMNS)
                    {
                        trailor.queryParts.IsSelectAll = true;
                        //Add all columns
                    }
                }
                Wildcard.Value.Traverse(visitor);
            }

            if (m_expressionArguments != null)
            {
                m_expressionArguments.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
