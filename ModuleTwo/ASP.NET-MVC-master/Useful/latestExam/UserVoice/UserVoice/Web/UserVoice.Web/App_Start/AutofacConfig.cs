using Autofac;
using Autofac.Integration.Mvc;
using UserVoice.Data;
using UserVoice.Data.Common;
using UserVoice.Services.Data.Interfaces;
using UserVoice.Services.Web;
using UserVoice.Web.Controllers;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Reflection;
using System.Web.Mvc;

namespace UserVoice.Web.App_Start
{
    public static  class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // Register services
            RegisterServices(builder);

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            builder.Register(x => new ApplicationDbContext()).As<DbContext>();
            builder.Register(x => new HttpCacheService()).As<ICacheService>();

            var servicesAssembly = Assembly.GetAssembly(typeof(IVotesService));
            builder.RegisterAssemblyTypes(servicesAssembly).AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(DbRepository<>)).As(typeof(IDbRepository<>)).InstancePerRequest();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AssignableTo<BaseController>().PropertiesAutowired();
        }
    }
}