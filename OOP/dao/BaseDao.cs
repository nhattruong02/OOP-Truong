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
        public Dictionary<string, List<BaseRow>> dic = new Dictionary<string, List<BaseRow>>()
        {
            { Common.Product, new List<BaseRow>()},
            { Common.Category, new List<BaseRow>()},
            { Common.Accesstion, new List<BaseRow>()}
        };
        public void insertTable(string name, BaseRow row) {
            if (dic.ContainsKey(name))
            {
                dic[name].Add(row);
            }
        }
        public void updateTable(string name, BaseRow row)
        {
            var o = dic[name].FirstOrDefault(o => o.id == row.id);
            if (o != null)
            {
                o.name = row.name;
                o.id = row.id;
            }
        }
        public void deleteTable(string name, BaseRow row)
        {
            var o = dic[name].FindAll(o => o.id == row.id);
            for (int i = 0; i < dic[name].Count; i++)
            {
                if (dic[name][i].id == row.id)
                    dic[name].Remove(dic[name][i]);
            }
        }
        public List<BaseRow> selectTable(string name)
        {
            return dic[name];
        }

    }
}
