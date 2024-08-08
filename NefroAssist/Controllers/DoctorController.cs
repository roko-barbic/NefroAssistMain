using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Models.Models.Staff;

namespace NefroAssist.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private readonly DataContext _context;

    public DoctorController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Doctor>> Get()
    {
        return await _context.Doctors.ToListAsync();
    }

    [HttpPost]
    public async Task<IActionResult> AddDoctor([FromBody] Doctor? doctorDto)
    {
        var doctors = await _context.Doctors.ToListAsync();
        if (doctorDto == null)
        {
            return BadRequest();
        }

        // doctors.Add(doctorDto);
        _context.Doctors.Add(doctorDto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = doctorDto.Id }, doctorDto);
    }

    [HttpDelete("/deleteDoctor/{id}")]
    public async Task<IActionResult> DeleteDoctor(int id)
    {
        var requestedDoctor =  await _context.Doctors.FirstOrDefaultAsync(a => a.Id == id);
        if (requestedDoctor == null)
        {
            return NotFound();
        }

        _context.Doctors.Remove(requestedDoctor);
        await _context.SaveChangesAsync();

        return Ok();
    }
}