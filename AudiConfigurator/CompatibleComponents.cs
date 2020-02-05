using AudiConfigurator.Interfaces;
using System;
using System.Collections.Generic;

namespace AudiConfigurator
{
    public class CompatibleComponents
    {
        private Car car;
        public List<IComponent> Options { get;}

        public CompatibleComponents(Car car, Type componentType)
        {
            this.car = car;

            Type RepositoryType = Type.GetType(componentType.Name + "Repository");
            IComponentRepository Repository = (IComponentRepository) Activator.CreateInstance(RepositoryType);

            Options = Repository.GetAllCompatibleComponents(car.Trim);
        }



    }
}