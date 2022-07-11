using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DBConnect.Models
{
    internal class Major
    {
        public string Code { get; set; }
        public string Title { get; set; }

        public Major(string code, string title)
        {
            Code = code;
            Title = title;
        }
        public override string ToString()
        {
            return Title;
        }

        public override bool Equals(object? obj)
        {
            return obj is Major major &&
                   Code == major.Code;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code);
        }
    }
}
