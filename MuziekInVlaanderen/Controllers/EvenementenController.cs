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

        /// <summary>
        /// Get alle evenementen
        /// </summary>
        /// <returns>Het evenement</returns>
        [HttpGet]
        public IEnumerable<Evenement> GetEvenementen()
        {
            return _evenementRepository.GetAll();
        }

        /// <summary>
        /// Get evenement via Id
        /// </summary>
        /// <param name="id">Het Id van het evenement</param>
        /// <returns>Het evenement</returns>
        [HttpGet("{id}")]
        public ActionResult<Evenement> GetEvenement(int id)
        {
            Evenement evenement = _evenementRepository.GetBy(id);
            if (evenement == null) return NotFound();
            return evenement;
        }

        /// <summary>
        /// Post een evenement
        /// </summary>
        /// <param name="evenement">Het evenement die je wilt posten</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Evenement> PostEvenement(Evenement evenement)
        {
            _evenementRepository.Add(evenement);
            _evenementRepository.SaveChanges();
            return CreatedAtAction(nameof(GetEvenement), new { id = evenement.Id }, evenement);
        }

        /// <summary>
        /// Update een evenement
        /// </summary>
        /// <param name="id">Het Id van het evenement</param>
        /// <param name="evenement">Het nieuwe evenement</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult PutEvenement(int id, Evenement evenement)
        {
            if (id != evenement.Id)
            {
                return BadRequest();
            }

            _evenementRepository.Update(evenement);
            _evenementRepository.SaveChanges();
            return NoContent();
        }

        /// <summary>
        /// Verwijder een evenement
        /// </summary>
        /// <param name="id">Het Id van het evenement</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<Evenement> DeleteEvenement(int id)
        {
            Evenement evenement = _evenementRepository.GetBy(id);
            if (evenement == null) return NotFound();
            _evenementRepository.Delete(evenement);
            _evenementRepository.SaveChanges();
            return evenement;
        }

    }
}