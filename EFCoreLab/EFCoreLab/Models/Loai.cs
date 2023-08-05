using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreLab.Models
{
	[Table("Loai")]
	public class Loai
	{
		[Key]
		public int MaLoai { get; set; }

		[MaxLength(50)]
		public string TenLoai { get; set; }

		public string? MoTa { get; set; }
		public string? Hinh { get; set; }
	}
}
