using System.Collections.Generic;
 
namespace AudiConfigurator
{
    class Car
    {
        public List<IComponent> components { get; set; }

        public Trim Trim { get; set; }

    }
}
