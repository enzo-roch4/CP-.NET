using API.NET.Data;
using API.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/brinquedo")]
[ApiController]
public class BrinquedoController : ControllerBase
{
    private readonly AppDbContext _context;

    public BrinquedoController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/brinquedo/buscar/{id}
    /// <summary>
    /// Obtém um brinquedo pelo ID.
    /// </summary>
    /// <param name="id">ID do brinquedo.</param>
    /// <returns>Retorna os dados do brinquedo.</returns>
    [HttpGet("buscar/{id}")]
    public async Task<ActionResult<Brinquedo>> GetById(int id)
    {
        var brinquedo = await _context.Brinquedo.FindAsync(id);
        if (brinquedo == null)
            return NotFound(new { message = "Brinquedo não encontrado" });

        return Ok(brinquedo);
    }

    // POST: api/brinquedo/cadastrar
    /// <summary>
    /// Cadastra um novo brinquedo.
    /// </summary>
    /// <returns>Retorna o brinquedo cadastrado.</returns>
    [HttpPost("cadastrar")]
    public async Task<ActionResult<Brinquedo>> Post([FromBody] Brinquedo brinquedo)
    {
        if (brinquedo == null)
            return BadRequest(new { message = "Dados inválidos" });

        _context.Brinquedo.Add(brinquedo);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = brinquedo.id_brinquedo }, brinquedo);
    }

    // PUT: api/brinquedo/atualizar/{id}
    /// <summary>
    /// Atualiza os dados de um brinquedo existente.
    /// </summary>
    /// <returns>Retorna 204 se atualizado com sucesso.</returns>
    [HttpPut("atualizar/{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Brinquedo brinquedo)
    {
        if (id != brinquedo.id_brinquedo)
            return BadRequest(new { message = "ID inconsistente" });

        var brinquedoExistente = await _context.Brinquedo.FindAsync(id);
        if (brinquedoExistente == null)
            return NotFound(new { message = "Brinquedo não encontrado" });

        _context.Entry(brinquedoExistente).CurrentValues.SetValues(brinquedo);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/brinquedo/apagar/{id}
    /// <summary>
    /// Exclui um brinquedo do banco de dados.
    /// </summary>
    /// <returns>Retorna mensagem de sucesso.</returns>
    [HttpDelete("apagar/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var brinquedo = await _context.Brinquedo.FindAsync(id);
        if (brinquedo == null)
            return NotFound(new { message = "Brinquedo não encontrado" });

        _context.Brinquedo.Remove(brinquedo);
        await _context.SaveChangesAsync();

        return Ok(new { message = "Brinquedo removido com sucesso" });
    }
}
