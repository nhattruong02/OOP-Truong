/*using OOP.dao;
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
        public static List<BaseRow> entities;
        public static void Main(string[] args)
        {


            initDatabase();
            print();

            Console.WriteLine("Deleted");
            Product product = new Product(5, Common.Product+"5", 5);
            productDAO.deleteTable(Common.Product, product);
            print();
            Console.WriteLine("Updated");
            updateTableTest();
            print();


        }
        private static void print()
        {
            entities = productDAO.selectTable(Common.Product);
            foreach (Product entity in entities)
            {
                Console.WriteLine(entity);
            }
        }
        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                Product product = new Product(i, Common.Product + i, i);
                productDAO.insertTable(Common.Product, product);
            }
        }


        private static void updateTableTest()
        {
            entities = productDAO.selectTable(Common.Product);
            Product p = new Product(1, Common.Product+"11", 2);
            productDAO.updateTable(Common.Product, p);
        }
    }
}
*/