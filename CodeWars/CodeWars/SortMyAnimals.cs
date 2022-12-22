using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58ff1c8b13b001a5a50005b4/train/csharp"/>
    [TestClass]
    public class SortMyAnimals
    {
        [TestMethod]
        public void Test()
        {
            var animals = new List<Animal>
              {
                new Animal {Name = "Cat", NumberOfLegs = 4},
                new Animal {Name = "Snake", NumberOfLegs = 0},
                new Animal {Name = "Dog", NumberOfLegs = 4},
                new Animal {Name = "Pig", NumberOfLegs = 4},
                new Animal {Name = "Human", NumberOfLegs = 2},
                new Animal {Name = "Bird", NumberOfLegs = 2}
              };
            var output = new AnimalSorter().Sort(animals);

            Assert.AreEqual(output[0].Name, "Snake");
            Assert.AreEqual(output[3].Name, "Cat");
        }

        public class Animal
        {
            public string Name { get; set; }
            public int NumberOfLegs { get; set; }
        }

        public class AnimalSorter
        {
            public List<Animal> Sort(List<Animal> input)
            {
                return input?.OrderBy(d => d.NumberOfLegs).ThenBy(d => d.Name).ToList();
            }
        }
    }
}
