using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class ShieldDecorator : VehicleDecorator
    {
        private int def = 8;

        public ShieldDecorator(IDecorator decorator) : base(decorator)
        {
            _def = def;
        }
    }
}
