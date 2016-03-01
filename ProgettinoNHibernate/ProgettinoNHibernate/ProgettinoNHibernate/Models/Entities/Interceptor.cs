using System.Diagnostics;
using NHibernate;
using NHibernate.SqlCommand;

namespace ProgettinoNHibernate.Models.Entities
{
    public class SqlStatementInterceptor : EmptyInterceptor
    {
        private static int _queryCount = 0;

        public override SqlString OnPrepareStatement(SqlString sql)
        {
            Debug.WriteLine($"{_queryCount++}: {sql}");
            return sql;
        }
    }
}