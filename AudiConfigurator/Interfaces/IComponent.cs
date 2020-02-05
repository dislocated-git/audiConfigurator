using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiConfigurator
{
    public interface IComponent
    {
        public string Name { get; }
        public int ID { get; }
        public int Price { get; }
    }
}
