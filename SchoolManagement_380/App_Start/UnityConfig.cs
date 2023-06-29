using SchoolManagement_380.Repository.Repository;
using SchoolManagement_380.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SchoolManagement_380
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IRegistrationRepository, RegistrationService>();
            container.RegisterType<ILoginRepository, LoginService>();
            container.RegisterType<IOrderRepository, OrderService>();
            container.RegisterType<IItemRepostery, ItemService>();
            container.RegisterType<ICoupanInterface, CoupenService>();
            container.RegisterType<ICountryRepository, CountryService>();
            container.RegisterType<IStateRepository, StateService>();
            container.RegisterType<ICityRepository, CityService>();
            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}