using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Factories
{
    public class WatercraftFactory : AbstractFactory<WatercraftFactory>, IFactory<IWatercraftVehicle>
    {
        public T Create<T>() where T : IWatercraftVehicle, new()
        {
            return new T();
        }
    }
}
