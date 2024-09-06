/*using OOP.dao;
using OOP.muck_entity;
using System;

namespace OOP.demo
{
    public class DatabaseDemo
    {
        public static List<BaseRow> entities;
        public static List<BaseRow> entities1;
        public static List<BaseRow> entities2;
        public static void Main(string[] args)
        {
            Database.Instance().selectTable(Common.Product);
            BaseDao dao = new ProductDAO();
            dao.selectTable(Common.Product);
            initDatabase();
            print();
            Console.WriteLine("Deleted");
            BaseRow product = new Product(5, Common.Product + 5, 5);
            Database.Instance().deleteTable(Common.Product, product);
            print();
            Console.WriteLine("Updated");
            updateTableTest();
            print();
            Database.Instance().truncateTable(Common.Product);
            if (entities.Count() <= 0)
            {
                Console.WriteLine("null");

            }
            else
            {
                foreach (BaseRow entity in entities)
                {
                    Console.WriteLine(entity);
                }
            }
        }

        private static void print()
        {
            entities = Database.Instance().selectTable(Common.Product);
            entities1 = Database.Instance().selectTable(Common.Category);
            entities2 = Database.Instance().selectTable(Common.Accesstion);
            foreach (BaseRow entity in entities)
            {
                Console.WriteLine(entity);
            }
            foreach (BaseRow entity in entities1)
            {
                Console.WriteLine(entity);
            }
            foreach (BaseRow entity in entities2)
            {
                Console.WriteLine(entity);
            }
        }

        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                BaseRow product = new Product(i, Common.Product + i, i);
                Database.Instance().insertTable(Common.Product, product);
                BaseRow category = new Category(i, Common.Category + i);
                Database.Instance().insertTable(Common.Category, category);
                BaseRow accessotion = new Accessotion(i, Common.Accesstion + i);
                Database.Instance().insertTable(Common.Accesstion, accessotion);
            }
        }

        private static void updateTableTest()
        {
            entities = Database.Instance().selectTable(Common.Product);
            BaseRow e = new Product(1, Common.Product + "11", 2);
            Database.Instance().updateTable(Common.Product, e);
        }
    }
}
*/