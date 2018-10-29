using Principal.Domain.Repositories;
using Principal.Domain.Services;
using Principal.Infra;
using Principal.Infra.DatabaseFactory;
using Principal.Infra.DatabaseFactory.DatabaseAdapters;
using Principal.Infra.Opportunity;
using Principal.Infra.Repositories;
using Principal.Infra.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Principal.IOC
{
    public class Register
    {
        public static void RegisterObjectInContainer(UnityContainer container)
        {
            RegisterMigration(container);
            RegisterRepositories(container);
        }

        private static void RegisterMigration(UnityContainer container)
        {
            container.RegisterType<IDatabaseAdapter, DatabaseAdapterSQLite>(new HierarchicalLifetimeManager());
            container.RegisterType<IMigrationWinAppRunner, MigrationRunnerWinApp>(new HierarchicalLifetimeManager());
        }

        private static void RegisterRepositories(UnityContainer container)
        {
            container.RegisterType<IPessoaRepositorio, PessoaRepositorio>(new HierarchicalLifetimeManager());
            container.RegisterType<IPessoaService, PessoaServico>(new HierarchicalLifetimeManager());
            container.RegisterType<IApprovedRepositorio, ApprovedRepositorio>(new HierarchicalLifetimeManager());
            container.RegisterType<IApprovedService, ApprovedServico>(new HierarchicalLifetimeManager());
            container.RegisterType<IOpportunityRepository, OpportunityRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITestemunhaRepositorio, TestemunhaRepositorio>(new HierarchicalLifetimeManager());
            container.RegisterType<IEscritorioRepositorio, EscritorioRepositorio>(new HierarchicalLifetimeManager());
            container.RegisterType<ITokenPublicoRepositorio, TokenPublicoRepositorio>(new HierarchicalLifetimeManager());
            container.RegisterType<IOpportunityService, OpportunityService>(new HierarchicalLifetimeManager());
            container.RegisterType<IRestClient, RestClient>(new HierarchicalLifetimeManager(), new InjectionConstructor());
            container.RegisterType<IRestRequest, RestRequest>(new HierarchicalLifetimeManager(), new InjectionConstructor());            
        }
    }

    }
