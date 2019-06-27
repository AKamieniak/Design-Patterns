using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Factories
{
    public sealed class LandcraftFactory : AbstractFactory<LandcraftFactory>, IFactory<ILandcraftVehicle>
    {
        public T Create<T>() where T : ILandcraftVehicle, new()
        {
            return new T();
        }
    }
}
