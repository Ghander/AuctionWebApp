using AuctionWebsite.Infrastructure;
using AuctionWebsite.Models;
using AuctionWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.Services
{
    public class AuctionItemsService
    {
        private AuctionItemsRepository _repo;

        public AuctionItemsService(AuctionItemsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<AuctionItemDTO> GetItems()
        {
            var items = (from ai in _repo.GetItems()
                    select new AuctionItemDTO
                    {
                        Id = ai.Id,
                        Name = ai.Name,
                        Decription = ai.Description,
                        MinBid = ai.MinBid,
                        NumberOfBids = ai.NumberOfBids,
                        Bids = (from b in ai.Bids
                                select new BidDTO
                                {
                                    Id = b.Id,
                                    Name = b.Name,
                                    BidAmount = b.BidAmount
                                }).ToList()
                    }).ToList();

            return items;
        }

        public void PostItem(AuctionItemDTO dto)
        {
            var item = new AuctionItem
            {
                Name = dto.Name,
                Description = dto.Decription,
                MinBid = dto.MinBid,
                NumberOfBids = dto.NumberOfBids
            };
            _repo.PostItem(item);
        }
    }
}
