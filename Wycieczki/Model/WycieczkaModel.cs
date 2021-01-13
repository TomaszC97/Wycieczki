using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wycieczki.Model
{
	[Table("Wycieczki")]
	public class WycieczkaModel
	{
		[Key]
		public int id { get; set; }
		public string poczatekTrasy { get; set; }
		public string konieTrasy { get; set; }
		public string dataWycieczki { get; set; }
		public string pokonanyDystans { get; set; }
		public string liczbaDni { get; set; }
		public string zdjecie { get; set; }
		public string video { get; set; }
	}
}
