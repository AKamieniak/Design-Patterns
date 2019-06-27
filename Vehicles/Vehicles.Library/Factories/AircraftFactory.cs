using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Factories
{
    public class AircraftFactory : AbstractFactory<AircraftFactory>, IFactory<IAircraftVehicle>
    {
        public T Create<T>() where T : IAircraftVehicle, new()
        {
            return new T();
        }
    }
}
