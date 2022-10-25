using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_winform.Classes
{
    internal class Build : IComparable
    {
        public string Title { get; }
        public string Address { get; }
        public Build(string title, string address)
        {
            this.Title = title;
            this.Address = address;
        }
        public override string ToString()
        {
            return Title + " " + Address;
        }
        public int CompareTo(object? o)
        {
            if (o is Build build) return Title.CompareTo(build.Title);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
