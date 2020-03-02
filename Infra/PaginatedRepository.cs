using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Domain.Common;

namespace Homework4.Infra
{
    public class PaginatedRepository<T>: FilteredRepository<T>, IPaging
    {
        public int PageIndex { get; set; }
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
    }
}