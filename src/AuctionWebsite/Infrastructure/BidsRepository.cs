using AuctionWebsite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.Infrastructure
{
    public class BidsRepository
    {
        private ApplicationDbContext _db;

        public BidsRepository(ApplicationDbContext db)
        {
            _db = db;
        }


    }
}
