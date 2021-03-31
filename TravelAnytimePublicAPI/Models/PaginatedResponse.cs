using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAnytimePublicAPI.Models
{
    public class PaginatedResponse<T>
    {
        public int count { get; set; }
        public int per_page { get; set; }
        public int current_page { get; set; }
        public T items { get; set; }

        public PaginatedResponse(int count, int per_page, int current_page, T items)
        {
            this.count = count;
            this.per_page = per_page;
            this.current_page = current_page;
            this.items = items;
        }
    }
}
