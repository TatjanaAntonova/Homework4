﻿using System;
using System.Linq;
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
        public int TotalPages => getTotalPages(PageSize);
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
        public int PageSize { get; set; } = 5;

        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
        internal int getTotalPages(in int pageSize)
        {
            var count = getItemsCount();
            var pages = countTotalPages(count, pageSize);

            return pages;
        }

        internal int countTotalPages(int count, in int pageSize) => (int)Math.Ceiling(count / (double)pageSize);

        private int getItemsCount() => base.createSqlQuery().CountAsync().Result;

        protected internal override IQueryable<TData> createSqlQuery()=> addSkipAndTake(base.createSqlQuery());

        private IQueryable<TData> addSkipAndTake(IQueryable<TData> query) => query
            .Skip((PageIndex - 1) * PageSize)
            .Take(PageSize);
    }
}