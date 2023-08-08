using Autofac;
using DoomsdayLogs.Tool.Application;
using DoomsdayLogs.Tool.Domain.LogModule;
using DoomsdayLogs.Tool.Domain.ProjectModule;
using DoomsdayLogs.Tool.Infrastructure.DAO;
using DoomsdayLogs.Tool.Infrastructure.DAO.LogModule;
using DoomsdayLogs.Tool.Infrastructure.DAO.ProjectModule;

namespace DoomsdayLogs.Tool
{
    public class AutoFacBuilder
    {
        public Autofac.IContainer Container { get; set; }

        public static IRegister Register = (IRegister)new AutoFacBuilder().Container.Resolve<FeaturesOperation>();

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
