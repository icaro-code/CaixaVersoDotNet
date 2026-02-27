using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoControle
{
    public class Container
    {
        public readonly Dictionary<Type, Type> _map = new();

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _map[typeof(TInterface)] = typeof(TImplementation);
        }

        public TInterface Resolve<TInterface>()
        {
            var interfaceType = typeof(TInterface);

            if (!_map.ContainsKey(interfaceType))
            {
                throw new InvalidOperationException($"Tipo não registrado: {interfaceType.Name}");
            }

            var implementation = _map[interfaceType];

            return (TInterface)Activator.CreateInstance(implementation);
        }

    }
}
