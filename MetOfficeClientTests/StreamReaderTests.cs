using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetOfficeClient.Models;
using NUnit.Framework;

namespace MetOfficeClientTests
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
