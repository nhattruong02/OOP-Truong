using OOP.muck_entity;
using System;
namespace OOP.demo
{
    public class Accessotion : Entity
    {
        public Accessotion(int id, string name) : base(id, name)
        {
        }

        public override void print()
        {
            Console.WriteLine("id:" + id + "name:" + name);
        }
        public override string ToString()
        {
            return "Accessotion\t" + "id:" + this.id + "\tName:" + this.name;
        }
    }
}
