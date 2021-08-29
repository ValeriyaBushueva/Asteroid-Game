using System;
using System.Collections.Generic;
using System.Linq;

public class ServiceLocator : IServiceLocator
{
    private readonly Dictionary<Type, List<object>> services
        = new Dictionary<Type, List<object>>();

    public void Register<TService>(object service)
    {
        var key = typeof(TService);
        if (!services.ContainsKey(key))
            services.Add(key, new List<object>());
        services[key].Add(service);
    }
    
    public TService Get<TService>()
    {
        if (services.ContainsKey(typeof(TService)))
        {
            return (TService)services[typeof(TService)].Single();
        }
        else
        {
            throw new InvalidOperationException(
                "Can't resolve service " + typeof(TService));
        }
    }
}
