using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class KnifeDecorator : VehicleDecorator
    {
        private int att = 4;

        public KnifeDecorator(IDecorator decorator) : base(decorator)
        {
            _att = att;
        }
    }
}
