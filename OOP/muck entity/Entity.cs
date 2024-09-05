using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.muck_entity
{
    public abstract class Entity
    {
        public int id { get; set; }
        public string name { get; set; }
        public Entity(int id, string name)
        {
            this.id = id;
            this.name = name;   
        }

        public abstract void print();
    }
}
