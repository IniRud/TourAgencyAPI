using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAgencyAPI.Models
{
    public class PaginatedResponse<T>
    {
        public int Count { get; set; }
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public T Items { get; set; }

        public PaginatedResponse(int count, int perpage, int currentpage, T items)
        {
            this.Count = count;
            this.PerPage = perpage;
            this.CurrentPage = currentpage;
            this.Items = items;
        }
    }
}
