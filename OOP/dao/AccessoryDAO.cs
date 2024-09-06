using OOP.demo;
using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.dao
{
    public class AccessoryDAO : BaseDao, IFunction<Accessotion>
    {
        public List<BaseRow> search(string name)
        {
           var o = dic[name].FindAll(o => o.name.Contains(name));
           return o;
        }

        public void searchByName(string name)
        {
            var o = dic[name].FirstOrDefault(o => o.name.Equals(name));
            if (o != null)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
