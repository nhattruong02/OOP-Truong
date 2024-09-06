using OOP.demo;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.dao
{
    public class ProductDAO : BaseDao, IFunction<Product>
    {
        /// <summary>
        /// Search table Product by name
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <returns></returns>
        public List<BaseRow> search(string name)
        {
            List<BaseRow> list = new List<BaseRow>();
            foreach (var row in Database.Instance().dic[Common.Product])
            {
                if (row.name.Contains(name))
                {
                    list.Add(row);
                }
            }
            return list;
        }

        public List<BaseRow> searchByName(string name)
        {
            List<BaseRow> list = new List<BaseRow>();
            foreach (var row in Database.Instance().dic[Common.Product])
            {
                if (row.name.Equals(name))
                {
                    list.Add(row);
                }
            }
            return list;
        }
    }
}
