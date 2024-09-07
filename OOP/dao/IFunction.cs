using OOP.muck_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.dao
{
    public interface IFunction<T>
    {
        public BaseRow searchByName(string name );
        public List<BaseRow> search(string name);
    }
}
