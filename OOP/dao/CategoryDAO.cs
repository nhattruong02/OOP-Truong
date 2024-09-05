using OOP.demo;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.dao
{
    public class CategoryDAO : IFunction<Category>
    {
        Database database;
        Dictionary<string, List<Category>> dic = new Dictionary<string, List<Category>>() {

            { COMMON.Category, new List<Category>()},

        };
        public CategoryDAO() {
            database = new Database();
        }

        public void deleteTable(string name, Category row)
        {
            if (dic.ContainsKey(name))
            {
                dic[name].Remove(row);
            }
        }


        public void insertTable(string name, Category row)
        {
            database.insertTable(name, row);
        }

        public List<Category> selectTable(string name)
        {
            return dic[name];
        }


        public void updateTable(string name, Category row)
        {
            var o = dic[name].FirstOrDefault(o => o.id == row.id);
            if (o != null)
            {
                o.name = row.name;
                o.id = row.id;
            }
        }

    }
}
