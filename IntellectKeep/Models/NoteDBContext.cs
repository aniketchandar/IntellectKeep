using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntellectKeep.Models
{
    //DBContext class is created
    public class NotesDBContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
    }
}
