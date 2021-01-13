using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wycieczki.Model;

namespace Wycieczki.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WycieczkiController : ControllerBase
	{
		private readonly WycieczkiContext _context;

		public WycieczkiController(WycieczkiContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<WycieczkaModel>>> GetWycieczki()
		{
			return await _context.Wycieczki.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<WycieczkaModel>> PostWycieczkaModel(WycieczkaModel wycieczkaModel)
		{
			_context.Wycieczki.Add(wycieczkaModel);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetWycieczkaModel", new { id = wycieczkaModel.id }, wycieczkaModel);
		}
	}
}
