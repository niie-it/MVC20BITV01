using System.ComponentModel.DataAnnotations;

namespace EFCoreFirst.Models
{
	public class Loai
	{
		[Key]
		public int MaLoai { get; set; }

		[MaxLength(50)]
		public string TenLoai { get; set; }

		public string? MoTa { get; set; }
		public string? Hinh { get; set; }

		public IEnumerable<HangHoa> HangHoas { get; set; }

		public Loai()
		{
			HangHoas = new List<HangHoa>();
			TenLoai = "";
		}

	}
}
