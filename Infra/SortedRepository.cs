using Homework4.Data.Common;
using Homework4.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Homework4.Infra
{
    public abstract class SortedRepository<TDomain, TData>: BaseRepository<TDomain, TData>, ISorting

        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()
    {
        public string SortOrder { get; set; }

        protected SortedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
    }
}