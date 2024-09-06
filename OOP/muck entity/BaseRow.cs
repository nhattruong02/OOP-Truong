using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.muck_entity
{
    public abstract class BaseRow
    {
        public int id { get; set; }
        public string name { get; set; }
        protected BaseRow(int id, string name)
        {
            this.id = id;
            this.name = name;   
        }

        protected abstract void print();
    }
}
