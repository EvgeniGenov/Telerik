using System;

namespace JumpJump
{
    class JumpJump
    {
        static void Main(string[] args)
        {
            string danceFloor = Console.ReadLine();


            for (int index = 0; index <= danceFloor.Length - 1; index++)
            {
                char currentSymbol = danceFloor[index];

                if (currentSymbol == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", index);
                    break;
                }

                else if (currentSymbol == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", index);
                    break;
                }
                else
                {
                    int currentNumber = int.Parse(danceFloor[index].ToString());

                    if (currentNumber % 2 == 0)
                    {
                        index += currentNumber - 1;
                    }
                    else if (currentNumber % 2 != 0)
                    {
                        index -= currentNumber + 1;
                    }
                }

                if (index + 1 < 0 || index + 1 > danceFloor.Length - 1)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", index + 1);
                    break;
                }

            }
        }
    }
}