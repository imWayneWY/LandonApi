using System.Collections.Generic;
using System.Linq;

namespace LandonApi.Models
{
    public class PagedResults<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalSize { get; set; }
    }
}
