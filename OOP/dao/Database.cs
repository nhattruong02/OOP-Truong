using System;
using System.Xml.Linq;
using System.Collections.Generic;
using OOP.demo;
using OOP.muck_entity;
using OOP.dao;

namespace OOP.demo
{
    public class Database 
    {
        private static Database _instance;
        public static Database Instance() {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }
        private Database()
        {
        }

        public Dictionary<string, List<BaseRow>> dic = new Dictionary<string, List<BaseRow>>()
        {
            { Common.Product, new List<BaseRow>()},
            { Common.Category, new List<BaseRow>()},
            { Common.Accesstion, new List<BaseRow>()}
        };

        /// <summary>
        /// Delete an object in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> object </param>
        /// <returns></returns>

        public void deleteTable(string name, BaseRow row)
        {
            var o = dic[name].FindAll(o => o.id == row.id);
            for (int i = 0; i < dic[name].Count; i++)
            {
                if (dic[name][i].id == row.id)
                    dic[name].Remove(dic[name][i]);
            }
        }

        /// <summary>
        /// Insert an object to dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> object </param>
        /// <returns></returns>
        public void insertTable(string name, BaseRow row)
        {
            if (dic.ContainsKey(name))
            {
                dic[name].Add(row);
            }
        }

        /// <summary>
        /// Get all object in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        public List<BaseRow> selectTable(string name)
        {
            return dic[name];
        }

        /// <summary>
        /// Update an object with key in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> object </param>
        /// <returns></returns>
        public void updateTable(string name, BaseRow row)
        {
            var o = dic[name].FirstOrDefault(o => o.id == row.id);
            if (o != null)
            {
                o.name = row.name;
                o.id = row.id;
            }
        }

        /// <summary>
        /// Delete all object with key in dictionary
        /// </summary>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> object </param>
        /// <returns></returns>
        public void truncateTable(string name)
        {

            dic[name].Clear();
        }

        /// <summary>
        /// Update an object by key in dictionary
        /// </summary>
        /// <param name="id"> id of object </param>
        /// <param name="name"> key of dictionary </param>
        /// <param name="row"> object </param>
        /// <returns></returns>
        public void updateTableById(int id, string name, BaseRow row)
        {
            var o = dic[name].FirstOrDefault(o => o.id == id);
            if (o != null)
            {
                o.id = row.id;
                o.name = row.name;
            }
        }
    }
}

