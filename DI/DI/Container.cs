namespace DI
{
    public class Container
    {
        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _services[typeof(TService)] = Activator.CreateInstance(typeof(TImplementation));
        }

        public TService Resolve<TService>()
        {
            if (_services.TryGetValue(typeof(TService), out var service))
            {
                return (TService)service;
            }
            throw new InvalidOperationException($"Service of type {typeof(TService)} not registered.");
        }
    }
}
