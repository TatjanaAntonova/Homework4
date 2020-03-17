﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework4.Pages
{
    public abstract class BasePage<TRepository, TDomain, TView>: PageModel
    where TRepository: ICrudMethods<TDomain>, ISorting, ISearching, IPaging
    {
        private TRepository db;

        protected internal BasePage(TRepository r)
        {
            db = r;
        }

        [BindProperty]
        public TView Item { get; set; }
        public IList<TView> Items { get; set; }

        public abstract string ItemId { get; }
        public string PageTitle { get; set; }
        public string PageSubtitle { get; set; }

        public string CurrentSort { get; set; } 

        public string CurrentFilter { get; set; } 
        public string SearchString { get; set; }

        public int PageIndex
        {
            get => db.PageIndex;
            set => db.PageIndex = value;
        }
        public bool HasPreviousPage => db.HasPreviousPage;
        public bool HasNextPage => db.HasNextPage;

        public int TotalPages => db.TotalPages;

        protected internal async Task<bool> addObject()
        {
            // TODO see viga tuleb lahendada
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            try
            {
                if (!ModelState.IsValid) return false;
                await db.Add(toObject(Item));
            }
            catch
            {
                return false;
            }
            return true;
        }

        protected internal abstract TDomain toObject(TView view);
        

        protected internal async Task updateObject()
        {
            // TODO see viga tuleb lahendada
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            await db.Update(toObject(Item));
        }

        protected internal async Task getObject(string id)
        {
            var o = await db.Get(id);
            Item = toView(o);
        }

        protected internal abstract TView toView(TDomain obj);

        protected internal async Task deleteObject(string id)
        {
            await db.Delete(id);
        }
        public string GetSortString(Expression<Func<MeasureData, object>> e, string page)
        {
            var name = GetMember.Name(e);
            string sortOrder;
            if (string.IsNullOrEmpty(CurrentSort)) sortOrder = name;
            if (!CurrentSort.StartsWith(name)) sortOrder = name;
            else if (CurrentSort.EndsWith("-desc")) sortOrder = name;
            else sortOrder = name + "_desc";

            return $"{page}?sortOrder={sortOrder}&currentFilter={CurrentFilter}";
        }

        protected internal async Task getList(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            sortOrder = string.IsNullOrEmpty(sortOrder) ? "Name" : sortOrder;
            CurrentSort = sortOrder;

            if (searchString != null) { pageIndex = 1; }
            else { searchString = currentFilter; }

            CurrentFilter = searchString;

            db.SortOrder = sortOrder;
            SearchString = CurrentFilter;
            db.SearchString = SearchString;

            PageIndex = pageIndex ?? 1;
            var l = await db.Get();
            Items = new List<TView>();

            foreach (var e in l) Items.Add(toView(e));
        }
    }
}

