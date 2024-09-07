using OOP.demo;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.dao
{
    public abstract class BaseDao
    {
        /// <summary>
        /// Add an object to dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> an object </param>
        
        public void insertTable(string name, BaseRow row) {
            if (Database.Instance().dic.ContainsKey(name))
            {
                Database.Instance().dic[name].Add(row);
            }
        }

        /// <summary>
        /// Update an object in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> an object </param>
        public void updateTable(string name, BaseRow row)
        {
            var o = Database.Instance().dic[name].FirstOrDefault(o => o.id == row.id);
            if (o != null)
            {
                o.name = row.name;
                o.id = row.id;
            }
        }

        /// <summary>
        /// Delete an object in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> an object </param>
        public void deleteTable(string name, BaseRow row)
        {
            var o = Database.Instance().dic[name].FindAll(o => o.id == row.id);
            for (int i = 0; i < Database.Instance().dic[name].Count; i++)
            {
                if (Database.Instance().dic[name][i].id == row.id)
                    Database.Instance().dic[name].Remove(Database.Instance().dic[name][i]);
            }
        }
        /// <summary>
        /// Get all object in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <returns> list object </returns>
        public List<BaseRow> selectTable(string name)
        {
            return Database.Instance().dic[name];
        }
        /// <summary>
        /// Get object by Id
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> object</param>
        /// <returns> object </returns>
        public BaseRow findByID(string name, BaseRow row)
        {
            List<BaseRow> list = Database.Instance().dic[name];
            var o = list.Find(o => o.id == row.id);
            return o;
        }
    }
}
