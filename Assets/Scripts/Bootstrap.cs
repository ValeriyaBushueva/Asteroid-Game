using System;
using DefaultNamespace;
using UnityEngine;


public class Bootstrap : MonoBehaviour
{
    [SerializeField] private ObjectPooler objectPooler;
    private ServiceLocator serviceLocator;
    
    private void Awake()
    {
        CreateServiceLocator();
        
        RegisterServices();

        InjectBulletBuilderWithServiceLocator();
    }

    private void CreateServiceLocator() => serviceLocator = new ServiceLocator();

    private void RegisterServices()
    {
        serviceLocator.Register<IObjectPool>(objectPooler);
    }

    private void InjectBulletBuilderWithServiceLocator() => BulletBuilder.InjectServiceLocator(serviceLocator);
}