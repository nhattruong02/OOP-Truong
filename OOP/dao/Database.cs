using System;
using System.Xml.Linq;

public class Database
{
    List<Product> productTable;
    List<Category> categoryTable;
    List<Accessotion> accessionsTable;
    public Database(List<Product> products, List<Category> category, List<Accessotion> accessions)
    {
        this.productTable = products;
        this.categoryTable = category;
        this.accessionsTable = accessions;
    }
    public void insertTable(string name, object row)
    {
        switch (name)
        {
            case "product":
                productTable.Add((Product)row);
                break;
            case "category":
                categoryTable.Add((Category)row);
                break;
            case "accession":
                accessionsTable.Add((Accessotion)row);
                break;
        }
    }
    public List<object> selectTable(string name)
    {
        switch (name)
        {
            case "product":
                return productTable.Cast<object>().ToList();
            case "category":
                return categoryTable.Cast<object>().ToList();
            case "accession":
                return accessionsTable.Cast<object>().ToList();
            default:
                throw new ArgumentException($"Table {name} does not exist.");
        }

    }
    public void deleteTable(string name, object row)
    {
        switch (name)
        {
            case "product":
                productTable.Remove((Product)row);
                break;
            case "category":
                categoryTable.Remove((Category)row);
                break;
            case "accession":
                accessionsTable.Remove((Accessotion)row);
                break;
        }
    }
    public void updateTable(string name, object row)
    {
        switch (name)
        {
            case "product":
                var product = (Product)row;
                var newProduct = productTable.FirstOrDefault(p => p.getId() == product.getId());
                if (newProduct != null)
                {
                    newProduct.setName(product.getName());
                    newProduct.setId(product.getId());
                    newProduct.setCategoryID(product.getCategoryID());
                }
                break;
            case "category":
                var category = (Category)row;
                var newCategory = categoryTable.FirstOrDefault(p => p.getId() == category.getId());
                if (newCategory != null)
                {
                    newCategory.setName(category.getName());
                    newCategory.setId(category.getId());

                }
                break;
            case "accession":
                var accession = (Accessotion)row;
                var newaccession = accessionsTable.FirstOrDefault(p => p.getId() == accession.getId());
                if (newaccession != null)
                {
                    newaccession.setName(accession.getName());
                    newaccession.setId(accession.getId());

                }
                break;
        }
    }

    public void truncateTable(string name)
    {
        switch (name)
        {
            case "product":
                productTable.Clear();
                break;
            case "category":
                productTable.Clear();
                break;
            case "accession":
                productTable.Clear();
                break;
        }
    }

}

