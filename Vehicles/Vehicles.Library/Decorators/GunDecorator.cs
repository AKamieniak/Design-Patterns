using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class GunDecorator : VehicleDecorator
    {
        private int att = 10;

        public GunDecorator(IDecorator decorator) : base(decorator)
        {
            _att = att;
        }
    }
}
