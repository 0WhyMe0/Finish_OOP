using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary_OOP
{
    internal class Author
    {
        public string name {  get; set; }
        public string alias { get; set; }

        public Author(string name, string alias)
        {
            this.name = name;
            this.alias = alias;
        }
    }
}
