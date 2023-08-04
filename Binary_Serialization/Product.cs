using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Serialization
{
    [Serializable]
    public class Product
    {//in c# it is called as attribute
        //[Serializable] to allow class to be serialized
        public int Id { get;set; }
        public string Name { get;set; }
        public int Price { get;set; }
    }
}
