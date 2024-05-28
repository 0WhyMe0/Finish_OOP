using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary_OOP
{
    internal class Track
    {
        public string name {  get; set; }
        public int duration { get; set; }
        public Author author { get; set; }

        public Track(string name, int duratoin, Author author)
        {
            this.name = name;
            this.duration = duration;
            this.author = author;
        }
    }
}
