using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/58e24788e24ddee28e000053/train/csharp"/>
    [TestClass]
    public class SimpleAssemblerInterpreter
    {
        [TestMethod]
        public void Test()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "a", 1 } }, Interpret(new[] { "mov a 5", "inc a", "dec a", "dec a", "jnz a -1", "inc a" }));
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "a", 0 }, { "b", -20 } }, Interpret(new[] { "mov a -10", "mov b a", "inc a", "dec b", "jnz a -2" }));
        }

        public static Dictionary<string, int> Interpret(string[] program)
        {
            var registers = new Dictionary<string, int>();

            for (int i = 0; i < program.Length; i++)
            {
                var commandWithParam = program[i].Split(' ');
                var command = commandWithParam[0];

                switch (command)
                {
                    case "mov":
                        {
                            var register = commandWithParam[1];

                            if (registers.ContainsKey(register))
                            {
                                registers[register] = int.TryParse(commandWithParam[2], out var number) ? number : registers[commandWithParam[2]];
                            }
                            else
                            {
                                registers.Add(register, int.TryParse(commandWithParam[2], out var number) ? number : registers[commandWithParam[2]]);
                            }
                        }
                        break;
                    case "inc":
                        {
                            registers[commandWithParam[1]]++;
                        }
                        break;
                    case "dec":
                        {
                            registers[commandWithParam[1]]--;
                        }
                        break;
                    case "jnz":
                        {
                            var value = int.TryParse(commandWithParam[1], out var num) ? num : registers[commandWithParam[1]];

                            if (value == 0)
                            {
                                break;
                            }

                            var value2 = int.TryParse(commandWithParam[2], out var number) ? number : registers[commandWithParam[2]];

                            i += value2 - 1;

                            continue;
                        }
                    default: break;
                }
            }

            return registers;
        }
    }
}
