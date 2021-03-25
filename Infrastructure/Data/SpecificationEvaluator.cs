using System.Linq;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQery, ISpecification<TEntity> spec)
        {
            var query = inputQery;
            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            query  = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
            return query;
        }
    }
}