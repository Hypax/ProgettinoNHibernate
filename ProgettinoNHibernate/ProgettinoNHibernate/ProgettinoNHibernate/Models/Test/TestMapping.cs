using FluentNHibernate;
using FluentNHibernate.Testing;
using NHibernate;
using NUnit.Framework;
using ProgettinoNHibernate.Models.Entities;



namespace ProgettinoNHibernate.Models.Test
{
    public class TestMapping
    {
        protected readonly string ConnectionString;
        private static ISession _session;
        public ISession Session
        {
            get
            {
                if (null == _session || !_session.IsOpen)
                {
                    var factory = SessionFactory.CreateSessionFactory(ConnectionString);
                    _session = factory.OpenSession();
                }
                return _session;
            }
        }

        [Test]
        public void TestMapping1()
        {
            new PersistenceSpecification<Negozi>(Session)
                .CheckProperty(c => c.IdNegozio, 1)
                .CheckProperty(c => c.Descrizione, "null")
                .CheckProperty(c => c.Citta, "Genova")
                .CheckProperty(c => c.Indirizzo, "Via del Campo")
                .VerifyTheMappings();
        }
    }
}

