﻿using System.Collections.Generic;
using System.Linq;
using Homework4.Data.Common;
using Homework4.Domain.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Homework4.Pages {

    public abstract class CommonPage<TRepository, TDomain, TView, TData> :
        PaginatedPage<TRepository, TDomain, TView, TData>
        where TRepository : ICrudMethods<TDomain>, ISorting, IFiltering, IPaging {

        protected internal CommonPage(TRepository r) : base(r) { }

        public abstract string ItemId { get; }

        public string PageTitle { get; set; }

        public string PageSubTitle => getPageSubTitle();

        protected internal virtual string getPageSubTitle() => string.Empty;

        public string PageUrl => getPageUrl();

        protected internal abstract string getPageUrl();

        public string IndexUrl => getIndexUrl();

        protected internal string getIndexUrl() => $"{PageUrl}/Index?fixedFilter={FixedFilter}&fixedValue={FixedValue}";

        protected static IEnumerable<SelectListItem> createSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : NamedEntityData, new() {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Name, m.Data.Id)).ToList();
        }


    }

}
