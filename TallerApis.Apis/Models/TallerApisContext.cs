using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    public class TallerApisContext : DbContext
    {
        public TallerApisContext() : base("TallerApisConnection")
        {

        }

        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}