using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public class Person
        {
            public string Firstname { get; set; }

            public string Lastname { get; set; }

        }
        public static List<Person> persons = new List<Person>();
    
        [HttpPost]
        public IActionResult PostPerson(Person person)
        {
            persons.Add(person);
            return CreatedAtAction(nameof(person), new { id = person.Firstname }, person);
        }
        public IActionResult GetAllPersons()
        {
            return Ok(persons);
        }
    }
}