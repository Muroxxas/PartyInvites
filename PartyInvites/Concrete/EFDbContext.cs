using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PartyInvites.Models;

namespace PartyInvites.Concrete
{
    public class EFDbContext : DbContext
    {
       public DbSet<GuestResponse> GuestResponses { get; set; }

        public EFDbContext() : base("name=EFDbContext")
        {

        }
    }
}