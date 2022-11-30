using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_winform
{
    internal class Person
    {
        public string FIO { get; }
        public string Sex { get; }
        public string Post { get; }
        public string Faculty { get; }
        public string Login { get; }
        public string Password { get; }
        public Person(string FIO, string Sex, string Post, string Faculty, string Login, string Password)
        {
            this.FIO = FIO;
            this.Sex = Sex;
            this.Post = Post;
            this.Faculty = Faculty;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
