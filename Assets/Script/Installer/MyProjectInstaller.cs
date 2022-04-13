using UnityEngine;
using Zenject;

public class MyProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<Model>()
            .AsSingle()
            .NonLazy();
    }
}