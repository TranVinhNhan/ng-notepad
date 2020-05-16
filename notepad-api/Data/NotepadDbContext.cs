using Microsoft.EntityFrameworkCore;
using notepad_api.Models;

namespace notepad_api.Data
{
    public class NotepadDbContext: DbContext
    {
        public NotepadDbContext(DbContextOptions<NotepadDbContext> options) : base(options)
        { }

        public DbSet<Notepad> Notepads { get; set; }
    }
}