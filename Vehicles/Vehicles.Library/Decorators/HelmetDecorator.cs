using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class HelmetDecorator : VehicleDecorator
    {
        private int def = 6;

        public HelmetDecorator(IDecorator decorator) : base(decorator)
        {
            _def = def;
        }
    }
}
