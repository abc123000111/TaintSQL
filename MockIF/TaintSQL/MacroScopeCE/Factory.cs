using System;
using System.Collections.Generic;
using System.Reflection;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace MacroScope
{
    /// <summary>
    /// Factory producing statement parsers and tailors.
    /// </summary>
    public static class Factory
    {
        #region Constants

        public static readonly string MSQLProvider = "System.Data.SqlClient";

        public static readonly string OleDbProvider = "System.Data.OleDb";

        public static readonly string OracleProvider = "Oracle.DataAccess.Client";

        #endregion

        #region Class map

        private static readonly Dictionary<string, Type> m_tailors =
            new Dictionary<string, Type>();

        #endregion

        #region Constructor

        static Factory()
        {
            m_tailors.Add(MSQLProvider, typeof(MSqlServerTailor));
            m_tailors.Add(OleDbProvider, typeof(MAccessTailor));
            m_tailors.Add(OracleProvider, typeof(OracleTailor));
        }

        #endregion

        #region Factory methods

        /// <summary>
        /// Parses the argument as a SQL statement and returns its tree.
        /// </summary>
        /// <param name="commandText">
        /// The SQL. Must not be null.
        /// </param>
        /// <returns>
        /// A statement instance (never null).
        /// </returns>
        public static IStatement CreateStatement(string commandText)
        {
            MacroScopeParser parser = CreateParser(commandText);
            return parser.statement();
        }

        public static MacroScopeParser CreateParser(string commandText)
        {
            if (commandText == null)
            {
                throw new ArgumentNullException("commandText");
            }

            MacroScopeLexer lexer = new MacroScopeLexer(
                new CaseInsensitiveStringStream(commandText));
            return new MacroScopeParser(new CommonTokenStream(lexer));
        }

        /// <summary>
        /// Produces an SQL tree walker which tries to convert the SQL
        /// to the syntax supported by a particular database engine.
        /// </summary>
        /// <param name="databaseProvider">
        /// Provider name (as in
        /// <see cref="System.Data.Common.DbProviderFactories.GetFactory"/>)
        /// specifying the target engine.
        /// </param>
        /// <returns>
        /// <see cref="MSqlServerTailor"/>, <see cref="MAccessTailor"/>
        /// or <see cref="OracleTailor"/> (never null).
        /// </returns>
        public static IVisitor CreateTailor(string databaseProvider)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            if (!m_tailors.ContainsKey(databaseProvider))
            {
                string message = string.Format("Unknown database provider {0}.",
                    databaseProvider);
                throw new ArgumentException(message, "databaseProvider");
            }

            Type type = m_tailors[databaseProvider];
            //ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);
            ConstructorInfo ctor = type.GetConstructor(new Type[0]);
            if (ctor == null)
            {
                string message = string.Format(
                    "Class {0} doesn't have an accessible default constructor.",
                    type.ToString());
                throw new Exception(message);
            }

            object tailor = ctor.Invoke(null);
            if (tailor == null)
            {
                string message = string.Format(
                    "Cannot construct {0}.",
                    type.ToString());
                throw new Exception(message);
            }

            return (IVisitor)tailor;
        }

        #endregion
    }
}
