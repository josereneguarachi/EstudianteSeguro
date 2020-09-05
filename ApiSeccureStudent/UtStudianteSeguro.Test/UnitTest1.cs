using System;
//using System.Collections.Generic;
using System.Net.Http;
//using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiSeccureStudent.Controllers;


namespace UtStudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsCotroller studentsCotroller = new StudentsCotroller();

            //Act
            var ListaEstudiante = studentsCotroller.GetStudents();


            //Assert
            Assert.IsNotNull(ListaEstudiante);
        }
    }
}
