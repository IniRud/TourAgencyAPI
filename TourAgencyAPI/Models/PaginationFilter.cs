using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourAgencyAPI.Models
{
    public class PaginationFilter
    {
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }

        public PaginationFilter()
        {
            this.PerPage = 2;
            this.CurrentPage = 1;
        }

        public PaginationFilter(int perpage, int currentpage)
        {
            this.PerPage = perpage > 10 ? 10 : perpage;
            this.CurrentPage = currentpage < 1 ? 1 : currentpage;
        }
    }
}
