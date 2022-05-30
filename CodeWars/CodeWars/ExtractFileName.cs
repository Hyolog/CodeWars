using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/597770e98b4b340e5b000071/train/csharp"/>
    [TestClass]
    public class ExtractFileName
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("FILE_NAME.EXTENSION", ExtractFileNameFunc("1_FILE_NAME.EXTENSION.OTHEREXTENSIONadasdassdassds34"));
            Assert.AreEqual("FILE_NAME.EXTENSION", ExtractFileNameFunc("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"));
        }

        public static string ExtractFileNameFunc(string dirtFileName)
        {
            var splited = dirtFileName.Split(new char[] { '.', '_' });
            var numbers = splited[0];
            var extension = splited[splited.Length - 1];

            return dirtFileName.Replace($"{numbers}_","").Replace($".{extension}", "");
        }
    }
}
