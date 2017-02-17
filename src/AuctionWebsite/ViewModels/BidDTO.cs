using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.ViewModels
{
    public class BidDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BidAmount { get; set; } 
        public AuctionItemDTO AuctionItem { get; set; }
    }
}
