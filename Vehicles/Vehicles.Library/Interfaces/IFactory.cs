namespace Vehicles.Library.Interfaces
{
    public interface IFactory<TT>
    {
        T Create<T>() where T : TT, new();
    }
}
