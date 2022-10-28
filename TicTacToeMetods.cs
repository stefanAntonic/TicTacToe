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
                    EnterXorOVAlue(Player, Input);
                }
                   
                else if (Player == 1)
                {
                    Player = 2;
                    EnterXorOVAlue(Player, Input);
                }
                SetField();

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
                    

                } while (!InputCorrect);
                 
            }
            while (true) ;
        }

        public void EnterXorOVAlue(int player, int input)
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