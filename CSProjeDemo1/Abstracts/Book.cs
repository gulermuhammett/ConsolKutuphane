using CSProjeDemo1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstracts
{
    public abstract class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public int ReleaseDate { get; set; }
        public Status Status  { get; set; }
    }
}
