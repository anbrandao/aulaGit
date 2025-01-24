using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

   [HttpPost]
   public IActionResult AdicionaFilme([FromBody] Filme filme)
   {
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
   }

   [HttpGet]
   public IEnumerable<Filme> RecuperaFilmes()
   {
      return filmes;
   }


   [HttpGet]
   public IEnumerable<Filme> RecuperaFilmes([FromQuery]int skip = 0, [FromQuery]int take = 50)
   {
      return filmes.Skip(skip).Take(take);
   }
}
