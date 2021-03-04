using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Helpers
{
    public class PaginatedList<T>
    {
        public int Size { get; set; }
        public int Index { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }

        public IEnumerable<T> Items { get; set; }

        public PaginatedList(IEnumerable<T> items, int count, int pageIndex, int pageSize)
        {
            Size = pageSize;
            Index = pageIndex;
            Count = count;
            Pages = (int)Math.Ceiling(count / (double)pageSize);

            HasNext = pageIndex < Pages;
            HasPrevious = pageIndex > 1;

            Items = items;
        }
    }
}
