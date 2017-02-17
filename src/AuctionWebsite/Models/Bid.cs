using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BidAmount { get; set; }

        public int AuctionItemId { get; set; }
        [ForeignKey("AuctionItemId")]
        public AuctionItem AuctionItem { get; set; }
    }
}
