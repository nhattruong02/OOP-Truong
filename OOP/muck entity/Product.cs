using System;

public class Product
{
    private int _id;
    private string _name;
    private int _categoryId;

    public Product(int id, string name, int categoryID)
    {
        this._id = id;
        this._name = name;
        this._categoryId = categoryID;
    }
    public int getId()
    {
        return this._id;
    }
    public void setId(int id)
    {
        this._id = id;
    }
    public string getName()
    {
        return this._name;
    }
    public void setName(string name)
    {
        this._name = name;
    }
    public int getCategoryID()
    {
        return this._categoryId;
    }
    public void setCategoryID(int categoryID)
    {
        this._categoryId = categoryID;
    }

    public void printProduct(Product product)
    {
        Console.WriteLine("Id:" + product._id + "\t" + "Name:" + product._name + "\t" + "CategoryId:" + product._categoryId);
    }


}
