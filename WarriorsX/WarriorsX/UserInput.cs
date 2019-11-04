using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsX
{
    class UserInput
    {

        Player player = new Player();
        Movement movement = new Movement();

        ConsoleKeyInfo enterKey = Console.ReadKey(true);
        public UserInput() { }

        public ConsoleKeyInfo EnterKey { get => enterKey; set => enterKey = value; }

        public void AskUserInput()
        {

                if (EnterKey.Key != ConsoleKey.Escape) 
                {

                    switch (EnterKey.Key)
                    {
                        case ConsoleKey.Enter:
                            player.takeDamage();
                            break;

                        case ConsoleKey.W:
                            movement.jump();
                            break;

                        case ConsoleKey.S:
                            movement.duck();
                            break;

                        case ConsoleKey.D:
                            movement.moveRight();
                            break;

                        case ConsoleKey.A:
                            movement.moveLeft();
                            break;

                        case ConsoleKey.UpArrow:
                            movement.jump();
                            break;

                        case ConsoleKey.DownArrow:
                            movement.duck();
                            break;

                        case ConsoleKey.RightArrow:
                            movement.moveRight();
                            break;

                        case ConsoleKey.LeftArrow:
                            movement.moveLeft();
                            break;

                        default: 
                            try
                            {
                                if (EnterKey.Key == ConsoleKey.Spacebar)
                                {
                                    throw new InvalidUserKey();
                                }
                            }

                            catch (InvalidUserKey ex)
                            {
                                Console.WriteLine("Please enter a valid key");
                            }
                            break;
                    }
                }
        }
    }
}
