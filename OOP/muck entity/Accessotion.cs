using System;
public class Accessotion
{
    private int _id;
    private string _name;
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
    public Accessotion(int id, string name) {  
        this._id = id;
        this._name = name;
    }
}
