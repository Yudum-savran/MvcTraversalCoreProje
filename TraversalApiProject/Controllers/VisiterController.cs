using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalApiProject.DAL.Context;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class VisiterController : ControllerBase
    {
        VisiterContext context = new VisiterContext();

        [HttpGet]
        public IActionResult VisiterList()
        {
            var values = context.Visits.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddVisiter(Visit visit)
        {
            context.Add(visit);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult VisiterGet(int id)
        {
            var values = context.Visits.Find(id);
            if (values==null)
            {
                return NotFound();
            }
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult VisiterDelete(int id)
        {
            var values = context.Visits.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(values);
                context.SaveChanges();
                return Ok();
            }
           
        }

        [HttpPut]
        public IActionResult UpdateVisiter(Visit visit)
        {
            var values = context.Visits.Find(visit.VisitId);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                values.Name = visit.Name;
                values.Surname = visit.Surname;
                values.City = visit.City;
                values.Country = visit.Country;
                values.Mail = visit.Mail;
                context.Update(values);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
