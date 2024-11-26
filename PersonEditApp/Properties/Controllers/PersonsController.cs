using Microsoft.AspNetCore.Mvc;
using PersonEditApp.Models;

namespace PersonEditApp.Properties.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly BlazerPersonAppContext dbcontext;
        public PersonsController(BlazerPersonAppContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }
        [HttpGet]
        public IActionResult getCustomers()
        {
            try
            {
                return Ok(dbcontext.Persons.ToList());
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return NoContent();
            }
        }
        [HttpPost]
        public IActionResult postCustomer(Person customer)
        {
            try
            {
                dbcontext.Persons.Add(customer);
                dbcontext.SaveChanges();
                return Ok(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet("{id}")]
        public IActionResult getbyId(int id)
        {
            try
            {
                return Ok(dbcontext.Persons.Find(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut("{id}")]
        public IActionResult putCustomer(int id, Person customer)
        {
            try
            {

                var cust = dbcontext.Persons.Find(id);

                cust.Fname = customer.Fname;
                cust.Lname = customer.Lname;
                cust.Email = customer.Email;
                cust.Phone = customer.Phone;
                cust.Pass = customer.Pass;
                dbcontext.SaveChanges();
                return Ok(customer);
            }
            catch (Exception e)
            {
                return BadRequest(e + "User does not exist!");
            }
        }
    }
}
