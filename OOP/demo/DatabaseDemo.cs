using System;

public class DatabaseDemo
{
    private static List<Product> products = new List<Product>();
    private static List<Category> categories = new List<Category>();
    private static List<Accessotion> accessions = new List<Accessotion>();
    public static void Main(string[] args)
    {
    
        Database database = new Database(products, categories, accessions);
        for (int i = 1; i < 10; i++)
        {
            Product product = new Product(i, "product" + i, i);
            database.insertTable("product", product);
        }
        Product product1 = new Product(1, "category", 1);
        database.updateTable("product", product1);
        database.deleteTable("product", products[2]);

        foreach (Product product in products)
        {
            product.printProduct(product);
        }

    }
}
