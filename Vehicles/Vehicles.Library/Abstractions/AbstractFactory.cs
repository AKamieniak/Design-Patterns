namespace Vehicles.Library.Abstractions
{
    public abstract class AbstractFactory<T> where T : new()
    {
        private static T _instance;
        private static readonly object _syncRoot = new object();

        static AbstractFactory()
        {
        }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
