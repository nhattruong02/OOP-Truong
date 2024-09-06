using OOP.dao;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.demo
{
    public class ProducDAODemo
    {

        private static ProductDAO productDAO = new ProductDAO();
        public static List<Product> entities;
        public static void Main(string[] args)
        {


            initDatabase();
            print();

            Console.WriteLine("Deleted");
            Product product = new Product(5, "product5", 5);
            productDAO.deleteTable(COMMON.Product, product);
            print();
            Console.WriteLine("Updated");
            updateTableTest();
            print();


        }
        private static void print()
        {
            entities = productDAO.selectTable("product");
            foreach (Product entity in entities)
            {
                Console.WriteLine(entity);
            }
        }
        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                Product product = new Product(i, "product" + i, i);
                productDAO.insertTable("product", product);
            }
        }


        private static void updateTableTest()
        {
            entities = productDAO.selectTable("product");
            Product p = new Product(1, "product11", 2);
            productDAO.updateTable("product", p);
        }
    }
}
