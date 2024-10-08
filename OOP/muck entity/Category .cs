﻿using OOP.muck_entity;
using System;

namespace OOP.demo
{
    public class Category : BaseRow
    {
        public Category(int id, string name) : base(id, name)
        {
            this.id = id;
            this.name = name;
        }

        protected override void print()
        {
            Console.WriteLine("id:" + id + "name:" + name);
        }
        public override string ToString()
        {
            return "Category\t" + "id:" + this.id + "\tName:" + this.name;
        }
    }
}
