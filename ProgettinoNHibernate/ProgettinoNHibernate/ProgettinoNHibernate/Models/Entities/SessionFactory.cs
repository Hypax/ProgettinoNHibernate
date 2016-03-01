using System.Configuration;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using ProgettinoNHibernate.Models.Mappings;

namespace ProgettinoNHibernate.Models.Entities
{
    public static class SessionFactory
    {
        private static ISessionFactory _instance;
        public static ISessionFactory CreateSessionFactory(string connectionString)
        {

            if (null == _instance)
            {
                _instance =
                    Fluently.Configure().Database(MySQLConfiguration.Standard.ConnectionString(ConfigurationManager.ConnectionStrings["test"].ConnectionString))
                        .Mappings(m =>
                            m.AutoMappings
                                .Add(CreateAutomappings<Prodotti, ProdottiMap>))
                                .ExposeConfiguration(x => x.SetInterceptor(new SqlStatementInterceptor()))
                        .BuildSessionFactory();
            }
            return _instance;
        }

        private static AutoPersistenceModel CreateAutomappings<T, T1>() where T1 : IAutoMappingOverride<T>
        {
            // This is the actual automapping - use AutoMap to start automapping,
            // then pick one of the static methods to specify what to map (in this case
            // all the classes in the assembly that contains T), and then either
            // use the Setup and Where methods to restrict that behaviour, or (preferably)
            // supply a configuration instance of your definition to control the automapper.
            return AutoMap.AssemblyOf<T>().UseOverridesFromAssemblyOf<T1>();
        }
    }
}
