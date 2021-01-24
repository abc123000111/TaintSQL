using System;
using System.Collections.Generic;
using System.Text;
using MacroScope.AddedClasses;

namespace MacroScope
{
    public enum QueryStatementType { SELECT, UPDATE, DELETE, INSERT };
    public enum ParsingState { TYPE, TABLE, COLUMNS, WHERE, WHERECOND, DONE, WHERELHS, WHEREOP, WHERERHS, COLUMNVALUES, ASSIGN, FUNCTION };
    public enum Function { COUNT, AVG, MIN, MAX, FIRST, LAST, SUM };

    public class QueryParts
    {


        public QueryParts()
        {
            parsingState = ParsingState.TYPE;
            selectedColumns = new List<string>();
            selectedColumnFrom = new List<string>();
            tableNames = new List<string>();
        }

        #region fields

        private QueryStatementType type;
        private ParsingState parsingState;
        private bool isFucntionCall = false;
        private Function functionType;
        private bool distinct;

        public bool Distinct
        {
            get { return distinct; }
            set { distinct = value; }
        }



        private Dictionary<string, object> columnNameValueMap = new Dictionary<string, object>();
        public List<string> selectedColumns;
        public List<string> selectedColumnFrom;//Table in which a selected column is from

        /*If a wildcard is encountered in the query*/
        private bool isSelectAll = false;

        public Expression whereCondition;
        public Expression joinCondition;
        public string whereConditionLHS;
        public string whereConditionRHS;
        public string whereConditionop;
        private List<string> tableNames;

        #endregion

        #region properties


        public bool IsSelectAll
        {
            get { return isSelectAll; }
            set { isSelectAll = value; }
        }

        public bool IsFucntionCall
        {
            get { return isFucntionCall; }
            set { isFucntionCall = value; }
        }


        public Dictionary<string, object> ColumnNameValueMap
        {
            get { return columnNameValueMap; }
            set { columnNameValueMap = value; }
        }

        public ParsingState ParsingState
        {
            get { return parsingState; }
            set { parsingState = value; }
        }


        public QueryStatementType Type
        {
            get { return type; }
            set { type = value; }
        }


        public List<string> TableNames
        {
            get { return tableNames; }
            set { tableNames = value; }
        }

        public Function FunctionType
        {
            get { return functionType; }
            set { functionType = value; }
        }

        #endregion

    }
}
