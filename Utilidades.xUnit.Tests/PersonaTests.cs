using Xunit;
using Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Tests {
    public class ListaDePersonas {
        public List<Persona> lista { get; set; }

        public ListaDePersonas() {
            lista = new List<Persona>();
            lista.Add(new Persona { Id = 1, Nombre = "Pepito", Apellidos = "Grillo" });
            lista.Add(new Persona { Id = 2, Nombre = "Carmelo", Apellidos = "Coton" });
        }
    }

    public class PersonaTests: IClassFixture<ListaDePersonas> {
        ListaDePersonas fixture;

        public PersonaTests(ListaDePersonas fixture) {
            this.fixture = fixture;
        }

        [Fact()]
        public void ToStringTest() {
            Assert.Equal(2, fixture.lista.Count);
        }

        //[Fact()]
        //public void xMal() {
        //    fixture.lista.Add(new Persona());
        //    Assert.Equal(3, fixture.lista.Count);
        //}
    }


    [CollectionDefinition("Personas collection")]
    public class PersonasCollection : ICollectionFixture<ListaDePersonas> { }

    [Collection("Personas collection")]
    public class PersonasListTests {
        ListaDePersonas fixture;

        public PersonasListTests(ListaDePersonas fixture) {
            this.fixture = fixture;
        }

        [Fact()]
        public void ElementosTest() {
            Assert.Equal(2, fixture.lista.Count);
        }
    }

    [Collection("Personas collection")]
    public class PersonasTests {
        ListaDePersonas fixture;

        public PersonasTests(ListaDePersonas fixture) {
            this.fixture = fixture;
        }

        [Fact()]
        public void OtraPruebaTest() {
            Assert.Equal(2, fixture.lista.Count);
        }
    }

}