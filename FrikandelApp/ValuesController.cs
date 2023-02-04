using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrikandelApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = new List<string>();

            using (var db = new FrikandelContext())
            {
                // Create and save a new Blog


                var blog = new Person { Name = "Dyon" };
                db.People.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.People
                            orderby b.Name
                            select b;

                Console.WriteLine("All people in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                    result.Add(item.Name);
                }
                
            }
            return result;

        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
