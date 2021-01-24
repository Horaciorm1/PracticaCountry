using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebCountry.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebCountry.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<WebCountry.Models.Language> Languages { get; set; }

        public System.Data.Entity.DbSet<WebCountry.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<WebCountry.Models.RegionalBloc> RegionalBlocs { get; set; }

        public System.Data.Entity.DbSet<WebCountry.Models.Translation> Translations { get; set; }
    }
}