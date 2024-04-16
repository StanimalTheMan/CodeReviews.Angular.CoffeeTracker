using Microsoft.EntityFrameworkCore;

namespace CoffeeTracker.StanimalTheMan.Server.Models;

public class RecordDbContext : DbContext
{
	public DbSet<Record> Records { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=(LocalDb)\\LocalDBDemo;Database=CoffeeTracker;Trusted_Connection=True;");
	}
}
