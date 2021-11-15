using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using System.IO;

namespace DemoLibrary.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void Cargar_archivo_de_texto_El_nombre_valido_deberia_funcionar()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void Cargar_archivo_de_texto_El_nombre_valido_deberia_fallar()
        {
            Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadTextFile(""));
        }
    }
}
