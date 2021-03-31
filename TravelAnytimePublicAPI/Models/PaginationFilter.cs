using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAnytimePublicAPI.Models
{
    public class PaginationFilter
    {
        public int per_page { get; set; }
        public int current_page { get; set; }

        public PaginationFilter()
        {
            this.per_page = 2;
            this.current_page = 1;
        }

        public PaginationFilter(int per_page, int current_page)
        {
            this.per_page = per_page > 10 ? 10 : per_page;
            this.current_page = current_page < 1 ? 1 : current_page;
        }
    }
}
