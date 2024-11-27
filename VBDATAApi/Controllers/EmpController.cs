using Microsoft.AspNetCore.Mvc;
using VBDATAApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VBDATAApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        // GET: api/<EmpController>
        VBContext _context;
        public EmpController(VBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Emp> Get()
        {
            return _context.Emps.ToList();
        }

        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpController>
        [HttpPost]
        public void Post([FromBody] Emp value)
        {
            _context.Emps.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<EmpController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
