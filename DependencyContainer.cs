using Autofac;
using OM.DbContexts;

public class DependencyContainer
{
    public static void ConfigureContainer(ContainerBuilder builder)
    {
        // Register Context with Autofac
        builder.RegisterType<Context>()
               .AsSelf()
               .InstancePerLifetimeScope();

        // Register OfficeService with Autofac
        builder.RegisterType<OfficeService>()
               .As<IOffice>()
               .InstancePerLifetimeScope();

        // Additional registrations...

        // Do not use Populate here if you are already using it in Program.cs
        // builder.Populate(builder.Services);
    }
}
