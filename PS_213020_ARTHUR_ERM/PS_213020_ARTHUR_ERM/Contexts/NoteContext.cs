using Microsoft.EntityFrameworkCore;
using PS_213020_ARTHUR_ERM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS_213020_ARTHUR_ERM.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> option) : base(option)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
