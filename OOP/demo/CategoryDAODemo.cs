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

        private static CategoryDAO categorytDAO = new CategoryDAO();
        public static List<Category> categories;
        public static void Main(string[] args)
        {
            initDatabase();
            print();
            Console.WriteLine("Deleted");
            Category category = new Category(5, "category5");
            categorytDAO.deleteTable(COMMON.Category, category);
            print();
            Console.WriteLine("Updated");
            updateTableTest();
            print();


        }
        private static void print()
        {
            categories = categorytDAO.selectTable("category");
            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }
        }
        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                Category category = new Category(i, "category" + i);
                categorytDAO.insertTable("category", category);
            }
        }


        private static void updateTableTest()
        {
            categories = categorytDAO.selectTable("category");
            Category c = new Category(1, "category11");
            categorytDAO.updateTable("category", c);
        }
    }
}
*/