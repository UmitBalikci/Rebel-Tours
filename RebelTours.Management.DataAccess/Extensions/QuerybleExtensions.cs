using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelTours.Management.DataAccess.Extensions
{
    // Extensions Method şuan bunu kullanmıyorum hatırlamak amacıyla yazdım.
    public static class QuerybleExtensions
    {
        public static IQueryable<TEntity> IncludeMultiple<TEntity>(
            this IQueryable<TEntity> queryable,
            IEnumerable<string> includings)
            where TEntity : class
        {
            if (includings!= null)
            {
                foreach (var navProperty in includings)
                {
                    queryable = queryable.Include(navProperty);
                }
            }
            return queryable;
        }
    }
}
