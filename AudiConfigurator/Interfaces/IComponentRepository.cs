using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiConfigurator.Interfaces
{
    public interface IComponentRepository
    {
        public List<IComponent> GetAllCompatibleComponents(Trim trim);
    }
}
