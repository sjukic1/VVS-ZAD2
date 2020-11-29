using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Domari;

namespace UnitTestProject1
{
    [TestClass]
    public class PromjenaSobeTest
    {
        [TestMethod]
        public void TestKadaJeKapacitetVeci()
        {
            int brojSobe = 122;
            Student student1 = new Student(), student2 = new Student();
            StudentskiDom studentskiDom = new StudentskiDom(brojSobe);
            studentskiDom.Studenti.Add(student1);
            studentskiDom.Studenti.Add(student2);
            Soba soba = studentskiDom.Sobe[0];
            soba.Stanari.Add(student1);
            soba.Stanari.Add(student2);
            studentskiDom.PromjenaSobe(soba, 3);
            Assert.AreEqual(3, soba.Kapacitet);
        }

        [TestMethod]
        public void TestKadaJeKapacitetIsti()
        {
            int brojSobe = 350;
            Student student1 = new Student(), student2 = new Student();
            StudentskiDom studentskiDom = new StudentskiDom(brojSobe);
            studentskiDom.Studenti.Add(student1);
            studentskiDom.Studenti.Add(student2);
            Soba soba = studentskiDom.Sobe[0];
            soba.Stanari.Add(student1);
            soba.Stanari.Add(student2);
            studentskiDom.PromjenaSobe(soba, 2);
            Assert.AreEqual(2, soba.Kapacitet);
        }

        [TestMethod]
        public void TestKadaJeKapacitetManji()
        {
            int brojSobe = 350;
            Student student1 = new Student(), student2 = new Student();
            StudentskiDom studentskiDom = new StudentskiDom(brojSobe);
            studentskiDom.Studenti.Add(student1);
            studentskiDom.Studenti.Add(student2);
            Soba soba = studentskiDom.Sobe[0];
            soba.Stanari.Add(student1);
            soba.Stanari.Add(student2);
            studentskiDom.PromjenaSobe(soba, 1);
            Assert.AreEqual(1, soba.Kapacitet);
        }

        [TestMethod]
        public void TestPromjeneMatcnogFakulteta()
        {
            Student student = new Student();
            string fakultet = "Pravo";
            int godine = 1, ciklus = 1;
            student.Skolovanje = new Skolovanje();
            student.PromjenaInformacijaOSkolovanju(fakultet, godine, ciklus);
            Assert.AreEqual(student.Skolovanje.MaticniFakultet, "Pravo");
        }

        [TestMethod]
        public void TestIstiMatcniFakultet()
        {
            Student student = new Student();
            string fakultet = "Elektrotehnički fakultet";
            int godine = 2, ciklus = 1;
            student.Skolovanje = new Skolovanje();
            student.PromjenaInformacijaOSkolovanju(fakultet, godine, ciklus);
            Assert.AreEqual(student.Skolovanje.MaticniFakultet, "Elektrotehnički fakultet");
            Assert.AreEqual(student.Skolovanje.GodinaStudija, 2);
        }

        [TestMethod]
        public void TestIstiMatcniFakultetRazlicitCiklusStudija()
        {
            Student student = new Student();
            string fakultet = "Elektrotehnički fakultet";
            int godine = 2, ciklus = 2;
            student.Skolovanje = new Skolovanje();
            student.PromjenaInformacijaOSkolovanju(fakultet, godine, ciklus);
            Assert.AreEqual(student.Skolovanje.MaticniFakultet, "Elektrotehnički fakultet");
            Assert.AreEqual(student.Skolovanje.GodinaStudija, 2);
            Assert.AreEqual(student.Skolovanje.CiklusStudija, 2);
        }
    }
}
