using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int players = 2;
            int input = 0;
            bool inputCorect = true;

            do
            {

                if (players == 2)
                {
                    players = 1;
                    EnterXorO('O', input);
                }
                else if (players == 1)
                {
                    players = 2;
                    EnterXorO('X', input);
                }
                SetField();




                #region
                char[] playerChars  = {'X','O'};

                foreach(char playerChar in playerChars)
                {
                    if (((playField[0,0] == playerChar) && (playField[0,1] == playerChar) && (playField[0,2] == playerChar))
                        || ((playField[1,0] == playerChar) && (playField[1,1] == playerChar) && (playField[1,2] == playerChar))
                        || ((playField[2,0] == playerChar) && (playField[2,1] == playerChar) && (playField[2,2] == playerChar))
                        || ((playField[0,0] == playerChar) && (playField[1,0] == playerChar) && (playField[2,0] == playerChar))
                        || ((playField[0,1] == playerChar) && (playField[1,1] == playerChar) && (playField[2,1] == playerChar))
                        || ((playField[0,2] == playerChar) && (playField[2,1] == playerChar) && (playField[2,2] == playerChar))
                        || ((playField[0,0] == playerChar) && (playField[1,1] == playerChar) && (playField[2,2] == playerChar))
                        || ((playField[0,2] == playerChar) && (playField[1,1] == playerChar) && (playField[2,0] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\n We have a WINNER! Player 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\n We have a WINNER! Player 1 has won!");
                        }
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        Resetfield();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("There is no winner! DRAW GAME!!!");
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        Resetfield();
                        break;
                    }
                }
                #endregion




                #region
                do
                {
                    Console.WriteLine("\n Player {0} : Choose your field!", players);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorect = true;
                    else
                    {
                        Console.WriteLine("Incorret input! Please use another feild");
                        inputCorect = false;
                    }



                } while (!inputCorect);
                #endregion



            } while (true);
        }


        public static void Resetfield()
        {
            char[,] playFieldInitial =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };

            playField = playFieldInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |       |       ");
            Console.WriteLine(" {0}   |  {1}    |  {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_______|_______");

            Console.WriteLine("     |       |       ");
            Console.WriteLine(" {0}   |  {1}    |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_______|_______");

            Console.WriteLine("     |       |       ");
            Console.WriteLine(" {0}   |  {1}    |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |       |       ");
            turns++;
        }

        public static void EnterXorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }
    }
}
