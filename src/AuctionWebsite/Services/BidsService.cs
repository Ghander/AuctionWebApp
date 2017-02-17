using AuctionWebsite.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionWebsite.Services
{
    public class BidsService
    {
        private BidsRepository _repo;

        public BidsService(BidsRepository repo)
        {
            _repo = repo;
        }
    }
}
