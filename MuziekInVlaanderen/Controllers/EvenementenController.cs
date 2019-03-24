using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuziekInVlaanderen.Models.Domain;

namespace MuziekInVlaanderen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenementenController : ControllerBase
    {
        private readonly IEvenementRepository _evenementRepository;
        public EvenementenController(IEvenementRepository context)
        {
            _evenementRepository = context;
            Console.Write(_evenementRepository.GetAll());
        }

        // GET: api/Evenementen
        [HttpGet]
        public IEnumerable<Evenement> GetEvenementen()
        {
            return _evenementRepository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Evenement> GetEvenement(int id)
        {
            Evenement evenement = _evenementRepository.GetBy(id);
            if (evenement == null) return NotFound();
            return evenement;
        }


        [HttpPost]
        public ActionResult<Evenement> PostEvenement(Evenement evenement)
        {
            _evenementRepository.Add(evenement);
            _evenementRepository.SaveChanges();
            return CreatedAtAction(nameof(GetEvenement), new { id = evenement.Id }, evenement);
        }

    }
}