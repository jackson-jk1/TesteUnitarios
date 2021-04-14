using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TesteUnitarioDio;

namespace TesteUnitarioTeste
{
    [TestClass]
    public class FileProcessTeste
    {

        [TestMethod]
        public void FileNameDoesExists()

        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");
            
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;
            fromCall = fp.FileExists(@"C:\Regedit.exe");
            Assert.IsFalse(fromCall);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowException()
        {
            FileProcess fp = new FileProcess();
            fp.FileExists("");
        }
    }
}
