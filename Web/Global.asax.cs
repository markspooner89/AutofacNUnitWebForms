using Autofac;
using Autofac.Integration.Web;
using System;
using System.Web;
using Web.Repository;
using Web.Repository.Interfaces;
using Web.Services;
using Web.Services.Interfaces;

namespace Web
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        private static IContainerProvider _containerProvider;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PersonRepository>()
                .As<IPersonRepository>()
                .InstancePerRequest();

            builder.RegisterType<PersonService>()
                .As<IPersonService>()
                .InstancePerRequest();

            _containerProvider = new ContainerProvider(builder.Build());
        }
    }
}