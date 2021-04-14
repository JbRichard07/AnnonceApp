using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class MenbresController : ControllerBase
    {
        private readonly DataContext _context;
        public MenbresController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Menbre>>> GetMenbres()
         {
            return await _context.Menbres.ToListAsync();
           
         }

         [HttpGet("{id}")]

        public async Task<ActionResult<Menbre>> GetMenbre(int id)
         {
            return await _context.Menbres.FindAsync(id);
            
         }
    }
}