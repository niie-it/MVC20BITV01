using Microsoft.EntityFrameworkCore;
using EFCoreLab.Models;

namespace EFCoreLab.Models
{
	public class MyDbContext : DbContext
	{
		// Table
		public DbSet<Loai> Loais { get; set; }
		public DbSet<HangHoa> HangHoas { get; set; }


		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }


		public DbSet<EFCoreLab.Models.Supplier>? Supplier { get; set; }

	}
}
