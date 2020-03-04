using Homework4.Data.Common;
using Homework4.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Homework4.Infra
{
    public abstract  class PaginatedRepository<TDomain, TData> : FilteredRepository<TDomain, TData>, IPaging
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()
    {
        public int PageIndex { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public int PageSize { get; set; } = 12;

        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
    }
}