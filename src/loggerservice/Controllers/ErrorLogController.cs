using System.Net;
using AutoMapper;
using loggerservice;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/errorlog")]
public class ErrorLogController : ControllerBase
{

    public readonly LoggerDbContext _context;

    public ErrorLogController(LoggerDbContext context){
        _context = context;
    }


    [HttpGet(Name ="GetErrorLogs")]
    public async Task<ActionResult<List<CustomError>>> GetErrorLogs(){
        var errors = await _context.CustomErrors.ToListAsync();
        return errors;
    }

    [HttpPost(Name ="PostErrorLogs")]
    public async Task<ActionResult> posErrorLog(CustomError customError){
        try{
            _context.CustomErrors.Add(customError);
            await _context.SaveChangesAsync();
            return Ok();
        }
        catch(Exception ex){
            return BadRequest();
        }
    }
}