/*using OOP.muck_entity;
using System;

namespace OOP.demo
{
    public class DatabaseDemo
    {
        private static Database database = new Database();
        public static List<Entity> entities;
        public static void Main(string[] args)
        {


            initDatabase();
            print();
            
            Console.WriteLine("Deleted");
            Entity product = new Product(5, "product5", 5);
            database.deleteTable(COMMON.Product,product);
            print();
            Console.WriteLine("Updated");
            updateTableTest();
            print();
            database.truncateTable("product");


            if (entities.Count() <= 0)
            {
                Console.WriteLine("null");

            }
            else
            {
                foreach (Entity entity in entities)
                {
                    Console.WriteLine(entity);
                }
            }

        }
        private static void print()
        {
            entities = database.selectTable("product");
            foreach (Entity entity in entities)
            {
                Console.WriteLine(entity);
            }
        }
        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                Entity product = new Product(i, "product" + i, i);
                database.insertTable("product", product);
            }
        }


        private static void updateTableTest()
        { 
            entities = database.selectTable("product");
            Entity e = new Product(1, "product11", 2);
            database.updateTable("product", e);
        }
    }
}
*/