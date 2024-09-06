using OOP.muck_entity;
using System;
namespace OOP.demo
{
    public class Accessotion : BaseRow
    {
        public Accessotion(int id, string name) : base(id, name)
        {
        }

        protected override void print()
        {
            Console.WriteLine("id:" + id + "name:" + name);
        }
        public override string ToString()
        {
            return "Accessotion\t" + "id:" + this.id + "\tName:" + this.name;
        }
    }
}
