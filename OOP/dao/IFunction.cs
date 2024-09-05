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

        public void insertTable(string name, T row );
        public void updateTable(string name, T row);
        public void deleteTable(string name, T row); 
        public List<T> selectTable(string name);
    }
}
