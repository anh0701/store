using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase{
    public static List <Product> products = new List<Product>();
    [HttpGet]
    public IActionResult GetResult(){
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id){
        try{
        // LINQ [Object] Query
            var product = products.SingleOrDefault(prod => prod.id == Guid.Parse(id));
            if(product == null){
                return NotFound();
            }
            return Ok(product);
        } catch{
            return BadRequest();
        }
    }

    [HttpPost]
    public IActionResult Create(ProductVM productVM){
        var product = new Product{
            id = Guid.NewGuid(),
            name = productVM.name,
            cost = productVM.cost
        };

        products.Add(product);
        return Ok(new {
            Success = true, Data = product
        });
    }

    [HttpPut("{id}")]
    public IActionResult Edit(string id, Product productU){
        try{
        // LINQ [Object] Query
            var product = products.SingleOrDefault(prod => prod.id == Guid.Parse(id));
            if(product == null){
                return NotFound();
            }

            if(id != product.id.ToString()){
                return BadRequest();
            }

            // update
            product.name = productU.name;
            product.cost = productU.cost;
            return Ok();
        } catch{
            return BadRequest();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Remove(string id){
                try{
        // LINQ [Object] Query
            var product = products.SingleOrDefault(prod => prod.id == Guid.Parse(id));
            if(product == null){
                return NotFound();
            }

            if(id != product.id.ToString()){
                return BadRequest();
            }

            // remove
            products.Remove(product);
            return Ok();
        } catch{
            return BadRequest();
        }

    }
}