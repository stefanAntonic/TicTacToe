using System;

namespace TicTacToe
{
    public class TicTaCToeMethods
    {
        public readonly char[,] PlayField =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };

        public int Player { get; set; }
        public int Input { get; set; }
        public bool InputCorrect { get; set; }

        public TicTaCToeMethods(int input = 0, bool inputCorrect = true, int player = 2)
        {
            Player = player;
            Input = input;
            InputCorrect = inputCorrect;
        }

        public void SetPlayers()
        {
            do
            {
                if (Player == 2)
                {
                    Player = 1;

                    EnterXorOValue(Player, Input);
                }

                else if (Player == 1)
                {
                    Player = 2;
                    EnterXorOValue(Player, Input);
                }
                    
                SetField();
                char[] playingChars = { 'X', 'O' };
                foreach (char playerChar in playingChars)
                {
                    if (((PlayField[0, 0] == playerChar) && (PlayField[0, 1] == playerChar) && (PlayField[0, 2] == playerChar))
                        || ((PlayField[1, 0] == playerChar) && (PlayField[1, 1] == playerChar) && (PlayField[1, 2] == playerChar))
                        || ((PlayField[2, 0] == playerChar) && (PlayField[2, 1] == playerChar) && (PlayField[2, 2] == playerChar))
                        || ((PlayField[0, 0] == playerChar) && (PlayField[1, 1] == playerChar) && (PlayField[2, 2] == playerChar))
                        || ((PlayField[0, 1] == playerChar) && (PlayField[1, 1] == playerChar) && (PlayField[2, 1] == playerChar))
                        || ((PlayField[0, 2] == playerChar) && (PlayField[1, 1] == playerChar) && (PlayField[2, 0] == playerChar))
                        || ((PlayField[1, 0] == playerChar) && (PlayField[1, 1] == playerChar) && (PlayField[1, 2] == playerChar))
                       )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\n Player 2 has won!");
                
                        } 
                        else if (playerChar == 'O')
                        {
                            Console.WriteLine("\n Player 1 has won!");
                        }
                    }
                }
                
                do
                {
                    Console.WriteLine($"Player {Player}: Chose your filed!");
                    try
                    {
                        Input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Enter valid field number;");

                    }

                    if ((Input == 1) && (PlayField[0, 0] == '1'))
                        InputCorrect = true;
                    else if ((Input == 2) && (PlayField[0, 1] == '2'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 3) && (PlayField[0, 2] == '3'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 4) && (PlayField[1, 0] == '4'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 5) && (PlayField[0, 1] == '5'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 6) && (PlayField[0, 2] == '6'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 7) && (PlayField[1, 0] == '7'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 8) && (PlayField[1, 1] == '8'))
                    {
                        InputCorrect = true;
                    }   else if ((Input == 9) && (PlayField[1, 2] == '9'))
                    {
                        InputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Insert correct input.");
                        InputCorrect = false;
                        Console.Clear();
                    }


                } while (!InputCorrect);
                 
            }
            while (true) ;
        }

        public void EnterXorOValue(int player, int input)
        {
            char xorOValue = player == 1 ? 'X' : 'O';
            
            switch (input)
            {
                case 1:
                    PlayField[0, 0] = xorOValue;
                    break;
                case 2:
                    PlayField[0, 1] = xorOValue;
                    break;
                case 3:
                    PlayField[0, 2] = xorOValue;
                    break;
                case 4:
                    PlayField[1, 0] = xorOValue;
                    break;
                case 5:
                    PlayField[1, 1] = xorOValue;
                    break;
                case 6:
                    PlayField[1, 2] = xorOValue;
                    break;
                case 7:
                    PlayField[2, 0] = xorOValue;
                    break;
                case 8:
                    PlayField[2, 1] = xorOValue;
                    break;
                case 9:
                    PlayField[2, 2] = xorOValue;
                    break;
            }
        }

        public void SetField()
        {
            Console.Clear();
            for (int i = 0; i < PlayField.GetLength(0); i++)
            {

                Console.WriteLine("|       |       |       |");
                Console.WriteLine("|   {0}   |   {1}   |   {2}   |", PlayField[i, 0], PlayField[i, 1], PlayField[i, 2]);
                Console.WriteLine("|_______|_______|_______|");

            }
        }

    }
}