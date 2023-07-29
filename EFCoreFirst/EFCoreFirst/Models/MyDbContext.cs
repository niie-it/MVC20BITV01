using Microsoft.EntityFrameworkCore;

namespace EFCoreFirst.Models
{
	public class MyDbContext : DbContext
	{
		public DbSet<Loai>? Loais { get; set; }
		public DbSet<HangHoa>? HangHoas { get; set; }

		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
	}
}
