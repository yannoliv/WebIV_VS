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

    }
}