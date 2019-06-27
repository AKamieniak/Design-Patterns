using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class AxeDecorator : VehicleDecorator
    {
        private int att = 7;

        public AxeDecorator(IDecorator decorator) : base(decorator)
        {
            _att = att;
        }
    }
}
