using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Repository;

namespace WebApplication4.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : Controller

    {
        private readonly IContactsRep _contatRep;
        public ContactsController (IContactsRep contactRep)
        {
            _contatRep = contactRep;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> GetContacts()
        {
            var contacts = _contatRep.GetAllContacts();
            return Ok(contacts);
        }
        [HttpGet("id")]
        public ActionResult<Contact> GetContact(int id)
        {
            var contact = _contatRep.GetContactById(id);
            return Ok(contact);

        }
        [HttpPost]
        public ActionResult<Contact> CreateContact([FromBody] Contact contact)
        {
            var contactreated = _contatRep.CreateContact(contact);
            return CreatedAtAction(nameof(GetContact), new { id = contactreated.ContactId }, contactreated);
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact contact)
        {
            _contatRep.UpdateContact(contact);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteContact(Contact contact)
        {
            _contatRep.DeleteContact(contact);
            return NoContent();

        }
    }
}
