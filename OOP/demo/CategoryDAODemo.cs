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
        private static BaseDao categorytDAO = new CategoryDAO();
        private static CategoryDAO categorytDAO1 = new CategoryDAO();
        public static List<BaseRow> categories;
        public static void Main(string[] args)
        {
            initDatabase();
            print();
            Console.WriteLine("Deleted");
            Category category = new Category(5, Common.Category + "5");
            categorytDAO.deleteTable(Common.Category, category);
            print();
            Console.WriteLine("Updated");
            updateTableTest();
            print();
            Console.WriteLine("Search By Name");
            Console.WriteLine(categorytDAO1.searchByName(Common.Category + "2").ToString());
            Console.WriteLine("Search");
            printSearch(categorytDAO1.search("1"));
        }


        private static void printSearch(List<BaseRow> list)
        {
            foreach (BaseRow row in list)
            {
                Console.WriteLine(row.ToString());
            }
        }

        private static void print()
        {
            categories = categorytDAO.selectTable(Common.Category);
            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }
        }

        private static void initDatabase()
        {
            for (int i = 1; i < 10; i++)
            {
                Category category = new Category(i, Common.Category + i);
                categorytDAO.insertTable(Common.Category, category);
            }
        }

        private static void updateTableTest()
        {
            categories = categorytDAO.selectTable(Common.Category);
            Category c = new Category(1, Common.Category + "11");
            categorytDAO.updateTable(Common.Category, c);
        }
    }
}
*/