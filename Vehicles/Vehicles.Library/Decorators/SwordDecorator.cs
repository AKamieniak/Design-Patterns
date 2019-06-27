using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class SwordDecorator : VehicleDecorator
    {
        private int att = 8;

        public SwordDecorator(IDecorator decorator) : base(decorator)
        {
            _att = att;
        }
    }
}
