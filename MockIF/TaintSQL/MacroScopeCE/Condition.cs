// -----------------------------------------------------------------------
// <copyright file="Condition.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace MacroScope.AddedClasses
{
    public class Condition
    {
        String lhs;

        public String Lhs
        {
            get { return lhs; }
            set { lhs = value; }
        }
        String rhs;

        public String Rhs
        {
            get { return rhs; }
            set { rhs = value; }
        }
        String op;

        public String Op
        {
            get { return op; }
            set { op = value; }
        }

    }
}
