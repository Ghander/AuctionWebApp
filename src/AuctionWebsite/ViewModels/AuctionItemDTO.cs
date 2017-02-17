using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.ViewModels
{
    public class AuctionItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public decimal MinBid { get; set; }
        public int NumberOfBids { get; set; }

        public ICollection<BidDTO> Bids { get; set; }
    }
}
