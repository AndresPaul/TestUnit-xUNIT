using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void Agregar_persona_a_la_lista_de_personas_deberia_funcionar()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Timy", LastName = "Torner" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Fact]
        public void Agregar_persona_con_nombre_numero_no_deberia_funcionar()
        {
            PersonModel newPerson = new PersonModel { FirstName = "12345", LastName = "Torner" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 0);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Fact]
        public void Agregar_persona_Sin_Nombre_a_la_lista_de_personas_no_deberia_adicionarse()
        {
            PersonModel newPerson = new PersonModel { FirstName = "", LastName = "Pedro" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 0);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Pedro", "", "LastName")]
        [InlineData("", "Paz", "FirstName")]
        public void Agregar_persona_a_la_lista_de_personas_deberia_fallar_esta_Vacio_un_campo(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
    }
}
