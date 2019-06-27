using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class GlovesDecorator : VehicleDecorator
    {
        private int def = 2;

        public GlovesDecorator(IDecorator decorator) : base(decorator)
        {
            _def = def;
        }
    }
}
