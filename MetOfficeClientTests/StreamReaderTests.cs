using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Met.Client.Models;
using NUnit.Framework;

namespace MetOfficeClient.Tests
{
    [TestFixture]
    public class StreamReaderTests
    {
        [Test]
        public void StreamTestCheck()
        {
            //Setup
            FileReadAndParse metOfficeClient = new FileReadAndParse();

            //Act
            string outputTextFile = metOfficeClient.ReadTextFile();

            //Assert
            Assert.IsNotNull(outputTextFile);
        }
    }
}
