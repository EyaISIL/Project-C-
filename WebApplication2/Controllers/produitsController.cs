using AngularASP1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class produitsController : ControllerBase
    {
        private readonly Context context;

        public produitsController(Context _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult Getproduits()
        {
            return Ok(context.produits);
        }

        [HttpPost]
        public IActionResult Createproduit([FromBody] produit produit)
        {
            context.produits.Add(produit);
            context.SaveChanges();
            return Ok(produit);
        }
    }
}
