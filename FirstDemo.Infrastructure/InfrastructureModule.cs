using Autofac;
using FirstDemo.Infrastructure.DbContexts;
using FirstDemo.Infrastructure.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace FirstDemo.Infrastructure
{
    public class InfrastructureModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public InfrastructureModule(string conncectionString, string migrationAssemblyName)
        {
            _connectionString = conncectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }


        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("conncectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseService>().As<ICourseService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
