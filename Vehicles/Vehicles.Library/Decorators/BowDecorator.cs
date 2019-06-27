using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class BowDecorator : VehicleDecorator
    {
        private int att = 8;

        public BowDecorator(IDecorator decorator) : base(decorator)
        {
            _att = att;
        }
    }
}
