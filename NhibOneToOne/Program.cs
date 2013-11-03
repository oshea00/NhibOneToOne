using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace NhibOneToOne
{
    class Program
    {
        static void Main(string[] args)
        {

            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var emp = new Employee { FirstName = "Steve", LastName = "O'Shea" };
                    emp.Boxer = new Boxer() { Employee = emp, WeightClass = "Heavyweight" };
                    session.Save(emp);

                    transaction.Commit();
                }
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString("Data Source=.;Initial Catalog=ARM;Integrated Security=True"))
                .Mappings(m =>
                    m.FluentMappings.AddFromAssemblyOf<Program>())
                //.ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
        }
    }
}
