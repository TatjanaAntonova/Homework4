﻿using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Domain.Common;

namespace Homework4.Infra
{
    public class FilteredRepository<T>: SortedRepository<T>, ISearching
    {
        public string SearchString { get; set; }
    }
}