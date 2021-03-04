using Utility.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace Utility.Extensions
{ 
    /// <summary>
    /// Handles the pagination task for both synchronous 
    /// and asynchronous applications 
    /// </summary>
    public static class PaginationExtension
    {
       
        //public static async Task<PaginatedList<T>> PageAsync<T>(this IQueryable<T> query, int? page, int? size) where T : class
        //{
        //    var Page = page ?? 1;
        //    var Size = size ?? 10;
        //    var count = await query.CountAsync();
        //    var items = await query.Skip(((Page) - 1) * Size).Take(Size).ToListAsync();

        //    return new PaginatedList<T>(items, count, Page, Size);
        //}

        public static PaginatedList<T> Page<T>(this IEnumerable<T> source, int? page, int? size) where T : class
        {
            var Page = page ?? 1;
            var Size = size ?? 10;
            var count = source.Count();
            var items = source.Skip((Page - 1) * Size).Take(Size).ToList();

            return new PaginatedList<T>(items, count, Page, Size);
        }


    }
}
