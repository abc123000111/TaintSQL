using System;

namespace MacroScope
{
    /// <summary>
    /// Represents a call to EXTRACT, a standard SQL function extracting
    /// datetime fields.
    /// </summary>
    public sealed class ExtractFunction : IExpression
    {
        #region Fields

        private readonly DateTimeUnit m_fieldSpec;

        private readonly IExpression m_source;

        #endregion

        #region Constructor

        public ExtractFunction(DateTimeUnit fieldSpec, IExpression source)
        {
            if (fieldSpec == null)
            {
                throw new ArgumentNullException("fieldSpec");
            }

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            m_fieldSpec = fieldSpec;
            m_source = source;
        }

        #endregion

        #region Properties

        public DateTimeUnit FieldSpec
        {
            get
            {
                return m_fieldSpec;
            }
        }

        public IExpression Source
        {
            get
            {
                return m_source;
            }
        }

        public bool IsComposed
        {
            get { return false; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            return new ExtractFunction((DateTimeUnit)(m_fieldSpec.Clone()),
                (IExpression)(m_source.Clone()));
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            m_fieldSpec.Traverse(visitor);
            visitor.PerformOnSource(this);
            m_source.Traverse(visitor);
            visitor.PerformAfter(this);
        }

        #endregion
    }
}
