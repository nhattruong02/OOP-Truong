using System;
using System.Xml.Linq;
using System.Collections.Generic;
using OOP.demo;
using OOP.muck_entity;
using OOP.dao;

namespace OOP.demo
{
    public class Database : IFunction<Entity>
    {
        Dictionary<string, List<Entity>> dic = new Dictionary<string, List<Entity>>()
        {
            { COMMON.Product, new List<Entity>()},
            { COMMON.Category, new List<Entity>()},
            { COMMON.Accesstion, new List<Entity>()}
        };

        public void deleteTable(string name, Entity row)
        {
            var o = dic[name].FindAll(o => o.id == row.id);
            for (int i = 0; i < dic[name].Count; i++)
            {
                if (dic[name][i].id == row.id)
                    dic[name].Remove(dic[name][i]);
            }
        }


        public void insertTable(string name, Entity row)
        {
            if (dic.ContainsKey(name))
            {
                dic[name].Add(row);
            }
        }

        public List<Entity> selectTable(string name)
        {
            return dic[name];
        }

        public void updateTable(string name, Entity row)
        {
            var o = dic[name].FirstOrDefault(o => o.id == row.id);
            if (o != null)
            {
                o.name = row.name;
                o.id = row.id;
            }
        }

        public void truncateTable(string name)
        {

            dic[name].Clear();
        }

        public void updateTableById(int id, string name, Entity row)
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

