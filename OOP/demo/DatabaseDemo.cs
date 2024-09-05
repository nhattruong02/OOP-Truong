﻿using OOP.muck_entity;
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
            entities = database.selectTable("product");
            foreach (Entity entity in entities)
            {
                Console.WriteLine(entity);
            }

/*            database.truncateTable("product");
            entities = database.selectTable("product");

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

            entities = database.selectTable("product");
            Entity e = new Product(1, "product100", 2);

            database.updateTable("product", e);*/

            updateTableTest();


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
            Console.WriteLine("Updated");
            entities = database.selectTable("product");
            Entity e = new Product(1, "product11", 2);
            database.updateTable("product", e);
            foreach (Entity entity in entities)
            {
                Console.WriteLine(entity);
            }
        }
    }
}
