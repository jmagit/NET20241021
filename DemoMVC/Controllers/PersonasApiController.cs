using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utilidades;

namespace DemoMVC.Controllers
{
    public class PersonasApiController : ApiController
    {
        // GET: api/PersonasApi
        public IEnumerable<Persona> Get()
        {
            var lista = new List<Persona>();
            lista.Add(new Persona { Id = 1, Nombre = "Pepito", Apellidos = "Grillo", FechaNacimiento = new DateTime(2000, 1, 2) });
            lista.Add(new Persona { Id = 2, Nombre = "Carmelo", Apellidos = "Coton", FechaNacimiento = new DateTime(2000, 12, 31) });
            return lista;
        }

        // GET: api/PersonasApi/5
        public Persona Get(int id)
        {
            return new Persona { Id = 1, Nombre = "Pepito", Apellidos = "Grillo", FechaNacimiento = new DateTime(2000, 1, 2) };
        }

        // POST: api/PersonasApi
        public void Post([FromBody]Persona value)
        {
        }

        // PUT: api/PersonasApi/5
        public void Put(int id, [FromBody]Persona value)
        {
        }

        // DELETE: api/PersonasApi/5
        public void Delete(int id)
        {
        }
    }
}
