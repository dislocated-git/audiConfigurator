using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiConfigurator
{
    class Car
    {
        public List<IComponent> components { get; set; }

        public Trim Trim { get; set; }

    }
}
