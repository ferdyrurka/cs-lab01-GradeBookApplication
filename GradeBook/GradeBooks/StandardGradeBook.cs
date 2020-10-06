using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public GradeBookType Type { get; set; }

        public StandardGradeBook(string name, bool IsWeight) : base(name, IsWeight)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
