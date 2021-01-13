using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wycieczki.Model
{
	public class WycieczkiContext : DbContext
	{
		public DbSet<WycieczkaModel> Wycieczki { get; set; }

		public WycieczkiContext(DbContextOptions options) : base(options)
		{

		}
	}
}
