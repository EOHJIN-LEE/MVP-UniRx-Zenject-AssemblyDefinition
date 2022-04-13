using Zenject;

public sealed class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<Presenter>()
            .AsSingle()
            .NonLazy();
    }
}