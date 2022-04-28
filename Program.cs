//01 Ponder and Prove Developer
//Drew LaMunyon

using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        //Here's my main function
        static void Main(string[] args)
        {
            //Create the player value
            string player = "x";
            
            //Create a list which we will use to draw our grid
            List<string> grid = new List<string>(){"1","2","3","4","5","6","7","8","9"};
            
            //Start the game loop using a boolean
            bool gameStatus = true;
            while (gameStatus)
            {
                //Call the function to draw the game grid
                drawGrid(grid);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                
                //Collect player input
                Console.Write($"{player}'s turn to choose a square (1-9) ");
                string selection = Console.ReadLine();

                //This while loop prevents users from breaking the code by inputting something other than 1-9
                while (selection != "1" && selection != "2" && selection != "3" && selection != "4" && selection != "5" && selection != "6" && selection != "7" && selection != "8" && selection != "9")
                {
                    Console.Write("Please enter a valid square (1-9)");
                    selection = Console.ReadLine();
                }


                Console.WriteLine(" ");
                
                //create a variable that stores the list index value of the selected square
                int selectionIndex = int.Parse(selection) - 1;
            

                //This section updates the game grid and checks for the win or draw status
                if (selection == grid[selectionIndex])
                {
                    
                    //This updates the list index with an x or an o
                    grid[selectionIndex] = player;
                    
                    //This code checks for a winner and ends the game
                    int winner = checkWinner(grid);
                    if (winner == 1)
                    {
                        drawGrid(grid);
                        Console.WriteLine(" ");
                        Console.WriteLine($"{player} is the winner!");
                        gameStatus = false;
                    }
                    
                    //This code checks for a draw and ends the game
                    int drawState = checkDraw(grid);
                    if (drawState == 1)
                    {
                        drawGrid(grid);
                        Console.WriteLine(" ");
                        Console.WriteLine("Draw :(");
                        gameStatus = false;
                    }
                    
                    //This code updates the player value
                    if (player == "x")
                    {
                        player = ("o");
                    }
                    else
                    {
                        player = ("x");
                    }
                }
                
                //This code prevents players from overwriting previously selected squares
                else{
                    Console.WriteLine("Invalid Square");
                }                
            }
        }

        //This function draws the game grid
        static void drawGrid(List<string> grid)
        {
            Console.WriteLine($"{grid[0]}|{grid[1]}|{grid[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{grid[3]}|{grid[4]}|{grid[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{grid[6]}|{grid[7]}|{grid[8]}");
        }

        //This function checks for a Draw. It returns a 1 if every square does not have its original numerical value
        static int checkDraw(List<string> grid)
        {
            if (grid[0] != "1" && grid[1] != "2" && grid[2] != "3" && grid[3] != "4" && grid[4] != "5" && grid[5] != "6" && grid[6] != "7" && grid[7] != "8" && grid[8] != "9")
            {
                return 1;
            }
            else
            {
                return 0;
            }            
        }

        //This function checks the game grid for every winning condition. It returns a 1 if there are three of the same symbols in a row
        static int checkWinner(List<string> grid)
        {
            if (grid[0] == grid[1] && grid[1] == grid[2])
            {
                return 1;
            }
            else if (grid[3] == grid[4] && grid[4] == grid[5])
            {
                return 1;
            }
            else if (grid[6] == grid[7] && grid[7] == grid[8])
            {
                return 1;
            }
            else if (grid[0] == grid[3] && grid[3] == grid[6])
            {
                return 1;
            }
            else if (grid[1] == grid[4] && grid[4] == grid[7])
            {
                return 1;
            }
            else if (grid[2] == grid[5] && grid[5] == grid[8])
            {
                return 1;
            }
            else if (grid[0] == grid[4] && grid[4] == grid[8])
            {
                return 1;
            }
            else if (grid[2] == grid[4] && grid[4] == grid[6])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}



