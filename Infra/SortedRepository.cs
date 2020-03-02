using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Domain.Common;

namespace Homework4.Infra
{
    public class SortedRepository<T>: BaseRepository<T>, ISorting
    {
        public string SortOrder { get; set; }
    }
}