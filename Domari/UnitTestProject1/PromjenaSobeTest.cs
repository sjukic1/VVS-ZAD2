using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Domari;

namespace UnitTestProject1
{
    [TestClass]
    public class PromjenaSobeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int brojSobe=122, kapacitet=2;
            Student student1 = new Student(), student2 = new Student();
            StudentskiDom studentskiDom = new StudentskiDom(brojSobe);
            studentskiDom.Studenti.Add(student1);
            studentskiDom.Studenti.Add(student2);
            Soba soba = studentskiDom.Sobe[0];
            studentskiDom.PromjenaSobe(soba, 3);
            Assert.AreEqual(3, soba.Kapacitet);
        }
    }
}