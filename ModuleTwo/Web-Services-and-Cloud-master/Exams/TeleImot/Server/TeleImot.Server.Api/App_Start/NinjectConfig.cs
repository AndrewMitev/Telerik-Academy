namespace TeleImot.Server.Api
{
    using System;
    using System.Data.Entity;
    using System.Web;

    using Ninject;
    using Ninject.Web.Common;
    using Data.Repositories;
    using Data;

    using Ninject.Extensions.Conventions;

    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ITeleImotDbContext>().To<TeleImotDbContext>();

            kernel.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));

            kernel.Bind(b => b.From("TeleImot.Services")
                .SelectAllClasses()
                .BindDefaultInterfaces());
        }
    }
}