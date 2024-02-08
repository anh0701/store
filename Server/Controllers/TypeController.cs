using Microsoft.AspNetCore.Mvc;
using Server.Context;
using Server.Entities;
using Server.Models;

namespace Server.Controllers;
[ApiController]
[Route("[Controller]")]

public class TypeController : ControllerBase{
    private readonly MyDbConText _context;
    public TypeController(MyDbConText conText){
        _context = conText;
    }

    [HttpGet]
    public IActionResult GetAll(){
        var listType = _context.types.ToList();
        return Ok(listType);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id){
        var type = _context.types.SingleOrDefault(lo => lo.id == id);
        if(type != null){
            return Ok(type);
        }
        else{
            return NotFound();
        }
    }
    [HttpPost]
    public IActionResult CreateNew(TypeModel model){
        try
        {
            var type = new TypeEntity{
                name = model.name
            };
            _context.Add(type);
            _context.SaveChanges();
            return Ok(type);
        }
        catch
        {
            return BadRequest();
        }
    }
    [HttpPut("{id}")]
    public IActionResult Update(int id, TypeModel model){
        var type = _context.types.SingleOrDefault(lo => lo.id == id);
        if(type != null){
            type.name = model.name;
            _context.SaveChanges();
            return NoContent();
        }
        else{
            return NotFound();
        }
    }

}