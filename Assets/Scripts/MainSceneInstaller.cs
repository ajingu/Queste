using Data.DataStore;
using Data.Network;
using Domain.Repository;
using Domain.UseCase;
using Presentation.Presenter;
using Zenject;

public class MainSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Container.Bind<IUserNetwork>().To<DummyUserNetwork>().AsSingle();
        Container.Bind<IUserNetwork>().To<ScriptableObjectUserNetwork>().AsSingle();
        Container.Bind<IUserDataStore>().To<UserDataStore>().AsSingle();
        Container.Bind<IUserRepository>().To<UserRepository>().AsSingle();
        Container.Bind<UserUseCase>().AsSingle();
        //Container.Bind<UserPresenter>().AsSingle();
    }
}