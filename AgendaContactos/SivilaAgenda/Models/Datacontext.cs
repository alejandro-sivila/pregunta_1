using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SivilaAgenda.Models
{
    public class Datacontext : DbContext
    {
        public Datacontext(): base("DefaultConnection")
        {

        }
    }
}