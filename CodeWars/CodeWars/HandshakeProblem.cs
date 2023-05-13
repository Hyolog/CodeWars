using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5574835e3e404a0bed00001b/train/csharp"/>
    [TestClass]
    public class HandshakeProblem
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0, GetParticipants(0));
            Assert.AreEqual(2, GetParticipants(1));
            Assert.AreEqual(3, GetParticipants(3));
            Assert.AreEqual(4, GetParticipants(6));
            Assert.AreEqual(5, GetParticipants(7));
        }

        public static int GetParticipants(int handshakes)
        {
            if (handshakes <= 0)
                return 0;

            int participants = 1;

            while (handshakes > 0)
            {
                participants++;
                handshakes -= participants - 1;
            }

            return participants;
        }
    }
}
