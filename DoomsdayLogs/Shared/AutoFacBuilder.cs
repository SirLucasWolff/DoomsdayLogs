using Autofac;
using DoomsdayLogs.Application.LogModule;
using DoomsdayLogs.Application.ProjectModule;
using DoomsdayLogs.Domain.LogModule;
using DoomsdayLogs.Domain.ProjectModule;
using DoomsdayLogs.Infra.ORM.LogModule;
using DoomsdayLogs.Infra.ORM.ProjectModule;
using DoomsdayLogs.InfraORM;
using DoomsdayLogs.WindowsForms.Features.LogModule;
using DoomsdayLogs.WindowsForms.Features.ProjectModule;

namespace DoomsdayLogs.WindowsForms.Shared
{
    public class AutoFacBuilder
    {
        public IContainer Container { get; set; }

        public static IRegister Register = new AutoFacBuilder().Container.Resolve<FeaturesOperation>();

        public AutoFacBuilder()
        {
            var Containerbuilder = new ContainerBuilder();

            Containerbuilder.RegisterType<DoomsdayLogsDbContext>().InstancePerLifetimeScope();

            RegisterORM(Containerbuilder);

            RegistrarAppService(Containerbuilder);

            RegistraOperacoes(Containerbuilder);

            Container = Containerbuilder.Build();
        }

        private static void RegistraOperacoes(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<FeaturesOperation>().InstancePerDependency();
        }

        private static void RegistrarAppService(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ProjectAppService>().InstancePerDependency();

            containerBuilder.RegisterType<LogAppService>().InstancePerDependency();
        }

        private static void RegisterORM(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ProjectOrmDAO>().As<ProjectRepositoryORM>().InstancePerDependency();

            containerBuilder.RegisterType<LogOrmDAO>().As<LogRepositoryORM>().InstancePerDependency();
        }
    }
}
