using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public class SqlConfiguration
    {
        public SqlConfiguration(string cone) => Conection = cone;
        public string Conection { get;}
    }
}
