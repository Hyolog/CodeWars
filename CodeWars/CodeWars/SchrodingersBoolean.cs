using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/5a5f9f80f5dc3f942b002309/train/csharp"/>
    [TestClass]
    public class SchrodingersBoolean
    {
        [TestMethod]
        public void Test()
        {
            Assert.IsTrue(omnibool == true);
            Assert.IsTrue(omnibool == false);
        }

        private static bool pivot = false;

        public static bool omnibool
        {
            get 
            { 
                if (pivot)
                {
                    pivot = false;
                }
                else
                {
                    pivot = true;
                }

                return pivot; 
            }
            set 
            { 
                omnibool = value; 
            }
        }
    }
}
