using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace DemoMVC.Controllers.Tests {
    [TestClass()]
    public class PersonasApiControllerTests {
        [TestMethod()]
        public void GetTest() {
            var api = new PersonasApiController();

            var actual = api.Get() as List<Persona>;
            Assert.AreEqual(2, actual.Count);
        }

        //[TestMethod()]
        //public void GetTest1() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void PostTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void PutTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DeleteTest() {
        //    Assert.Fail();
        //}
    }
}