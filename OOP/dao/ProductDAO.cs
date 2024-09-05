using OOP.demo;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.dao
{
    public class ProductDAO : IFunction<Product>
    {
        Dictionary<string, List<Product>> dic = new Dictionary<string, List<Product>>() {

            { COMMON.Product, new List<Product>()},

        };
        public void deleteTable(string name, Product row)
        {
            if (dic.ContainsKey(name))
            {
                dic[name].Remove(row);
            }
        }

        public void insertTable(string name, Product row)
        {
            if (dic.ContainsKey(name))
            {
                dic[name].Add(row);
            }
        }

        public List<Product> selectTable(string name)
        {
            return dic[name];
        }


        public void updateTable(string name, Product row)
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
