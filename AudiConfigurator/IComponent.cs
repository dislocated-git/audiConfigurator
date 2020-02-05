using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiConfigurator
{
    interface IComponent
    {
        public String Name { get; };
        public int ID { get; };
        public int Price { get; }
    }
}
