﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiConfigurator
{
    public class ExternalConfigurator
    {
        public List<CompatibleComponents> CompatibleComponents { get; }
        private Car car;

        public ExternalConfigurator(Car car)
        {
            CompatibleComponents = new List<CompatibleComponents>();
            foreach (IComponent component in car.components)
            {
                Type type = component.GetType();
                CompatibleComponents.Add(new CompatibleComponents(car, component.GetType()));
            }

            this.car = car;
        }
    }
}
