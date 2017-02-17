using AuctionWebsite.Data;
using AuctionWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.Infrastructure
{
    public class AuctionItemsRepository
    {
        private ApplicationDbContext _db;

        public AuctionItemsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IQueryable<AuctionItem> GetItems()
        {
            //if we didnt use IQueryable we would need to use Include
            //return _db.AuctionItems.Include(a => a.Bids).ToList();

            //both lines of code below do the same thing
            return _db.AuctionItems;
            //return from ai in _db.AuctionItems select ai;
        }

        public void PostItem(AuctionItem item)
        {
            _db.AuctionItems.Add(item);
            _db.SaveChanges();
        }
    }
}
