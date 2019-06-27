using Vehicles.Library.Interfaces;

namespace Vehicles.Library.Decorators
{
    public class VehicleDecorator : IDecorator
    {
        private IDecorator _decorator;

        protected int _att = 0;
        protected int _def = 0;

        public VehicleDecorator(IDecorator decorator)
        {
            _decorator = decorator;
        }

        public int GetAtt()
        {
            return _decorator.GetAtt() + _att;
        }

        public int GetDef()
        {
            return _decorator.GetDef() + _def;
        }
    }
}
