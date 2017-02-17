using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.Models
{
    public class AuctionItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MinBid { get; set; }
        public int NumberOfBids { get; set; }

        public ICollection<Bid> Bids { get; set; }
    }
}
