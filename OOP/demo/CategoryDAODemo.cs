/*using OOP.dao;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.demo
{
    public class CategoryDAODemo
    {
        private static CategoryDAO category = new CategoryDAO();
        public static List<Category> categories;
        public static void Main(string[] args)
        {

            initDatabase();
            categories = category.selectTable("category");
            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }

            *//*            database.truncateTable("product");*/
            /*            entities = database.selectTable("product");
            */
            /*            if (entities.Count() <= 0)
                        {
                            Console.WriteLine("null");

                        }
                        else
                        {
                            foreach (Entity entity in entities)
                            {
                                Console.WriteLine(entity);
                            }
                        }*/

            /*            entities = database.selectTable("product");
                        Entity e = new Product(1, "product100", 2);

                        database.updateTable("product", e);*/

          /*  updateTableTest();*//*


        }
        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                Category category1 = new Category(i, COMMON.Category + i);
                category.insertTable(COMMON.Category, category1);
            }
        }


        private static void updateTableTest()
        {
            Console.WriteLine("Updated");
            categories = category.selectTable(COMMON.Category);
            Category e = new Category(1, "category11");
            category.updateTable(COMMON.Category, e);
            foreach (Entity entity in categories)
            {
                Console.WriteLine(entity);
            }
        }
    }
}
*/