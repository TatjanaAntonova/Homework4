using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework4.Pages.Quantity
{
    public abstract class MeasuresPage : PageModel
    {
        protected internal readonly IMeasuresRepository data;

        protected internal MeasuresPage(IMeasuresRepository r)
        {
            data = r;
            PageTitle = "Measures";
        }

        [BindProperty]
        public MeasureView Item { get; set; }
        public IList<MeasureView> Items { get; set; }

        public string ItemId => Item.Id;
        public string PageTitle { get; set; }
        public string PageSubtitle { get; set; }

        public string CurrentSort { get; set; } = "Current sort";

        public string CurrentFilter { get; set; } = "Current filter";
        public string SearchString { get; set; }

        public int PageIndex
        {
            get => data.PageIndex; 
            set => data.PageIndex = value;
        }
        public bool HasPreviousPage => data.HasPreviousPage;
        public bool HasNextPage => data.HasNextPage;

        public int TotalPages => data.TotalPages;

        protected internal async Task<bool> addObject()
        {            
            // TODO see viga tuleb lahendada
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            try
            {
                if (!ModelState.IsValid) return false;
                await data.Add(MeasureViewFactory.Create(Item));
            }
            catch
            {
                return false;
            }
            return true;
        }

        protected internal async Task updateObject()
        {
            // TODO see viga tuleb lahendada
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            await data.Update(MeasureViewFactory.Create(Item));
        }

        protected internal async Task getObject(string id)
        {
            var o = await data.Get(id);
            Item = MeasureViewFactory.Create(o);
        }

        protected internal async Task deleteObject(string id)
        {
            await data.Delete(id);
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

            data.SortOrder = sortOrder;
            SearchString = CurrentFilter;
            data.SearchString = SearchString;

            PageIndex = pageIndex ?? 1;
            var l = await data.Get();
            Items = new List<MeasureView>();

            foreach (var e in l) Items.Add(MeasureViewFactory.Create(e));
        }
    }
}
