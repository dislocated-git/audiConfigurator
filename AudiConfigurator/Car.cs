using System.Collections.Generic;
 
namespace AudiConfigurator
{
    public class Car
    {
        public List<IComponent> components { get; set; }

        public Trim Trim { get; set; }

        public IComponent GetComponentByType(IComponent component)
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i].GetType() == component.GetType())
                {
                    return components[i];
                }
            }

            return null;
        }

        public void SetComponentByType(IComponent component)
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i].GetType() == component.GetType())
                {
                    components[i] = component;
                    return;
                }
            }
        }

    }
}
