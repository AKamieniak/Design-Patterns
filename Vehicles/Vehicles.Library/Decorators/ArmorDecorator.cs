using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class ArmorDecorator : VehicleDecorator
    {
        private int def = 10;

        public ArmorDecorator(IDecorator decorator) : base(decorator)
        {
            _def = def;
        }
    }
}
