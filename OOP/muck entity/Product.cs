using OOP.muck_entity;
using System;
namespace OOP.demo
{
    public class Product : Entity
    {

        private int _categoryId;

        public Product(int id, string name, int _categoryID) : base(id, name)
        {
            this.id = id;
            this.name = name;
            this._categoryId = _categoryID;
        }
        public int getCategoryID()
        {
            return this._categoryId;
        }


        public void setCategoryID(int categoryID)
        {
            this._categoryId = categoryID;
        }
        public override void print()
        {
            Console.WriteLine("id:" + this.id + "\tname:" + this.name + "\tcategory:" + this._categoryId);
        }
        public override string ToString()
        {
            return "Product\t" + "id:" + this.id + "\tName:" + this.name + "\tcategory:" + this._categoryId;
        }
    }
}