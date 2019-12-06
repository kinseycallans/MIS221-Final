using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PA5
{
    class MovieFile
    {
        static int count = 0;

        Movie m = new Movie();
        public static Movie[] myMovie = new Movie[500];

        public static void setCount(int temp)
        {
            count = temp;
        }

        public static int getCount()
        {
            return count;
        }
        

        //opens text file, reads in the contents of the text file and loads it into the myMovie array  
        public static Movie[] GetAllMovies()
        {

            StreamReader inFile = new StreamReader(@"C:\Users\12059\Source\Repos\PA5\movieinventory.txt");

            String input = inFile.ReadLine();
            while(input != null)
            {
                String[] temp = input.Split('#');
                myMovie[getCount()] = new Movie(temp[0], int.Parse(temp[1]), temp[2], int.Parse(temp[3]), temp[4]);
                setCount(getCount() + 1);
                input = inFile.ReadLine();
            }
            inFile.Close();

            return myMovie;
        }

        //adds a new movie object to the "myMovie" array
        public static void AddMovie(Movie m)
        {
            myMovie[getCount()] = m;
            setCount(getCount() + 1);
        }

        //opens the text file, loops through the myMovie array, & writes the contents of the array into the text file
        public static void SaveMovie()
        {
            StreamWriter outFile = new StreamWriter(@"C:\Users\12059\Source\Repos\PA5\movieinventory.txt");
         
            for (int i = 0; i < getCount(); i++)
            { 
                outFile.WriteLine(myMovie[i].getMovieTitle() + "#" + myMovie[i].getMovieID() + "#" + myMovie[i].getMovieGenre() + "#" + myMovie[i].getReleaseYear() +"#" + myMovie[i].getStock());         
            }
            
            outFile.Close();
        }

        public static void RemoveMovie(string userAnswer)
        {
            for (int i = 0; i < MovieFile.getCount(); i++)
            {
                if (int.Parse(userAnswer) == MovieFile.myMovie[i].getMovieID())
                {
                    for(int k = i; k < MovieFile.getCount() - 1; k++)
                    {
                        MovieFile.myMovie[k] = MovieFile.myMovie[k + 1];
                    }


                    setCount(getCount() - 1);
                }
            }
        }
    }

    public static void EditMovie(string UserAnswer)
    {
     Console.WriteLine("What field of " + userAnswer + " would you like to edit? Please select a number: \n" +
                            "1: Edit " + userAnswer + "'s movie title. \n" +
                            "2: Edit " + userAnswer + "'s movie ID. \n" +
                            "3: Edit " + userAnswer + "'s movie genre. \n" +
                            "4: Edit " + userAnswer + "'s release year. \n");
                        userAnswer = Console.ReadLine();
                        switch (userAnswer)
                        {
                            case "1":
                                Console.WriteLine("What would you like the new movie title to be?\n");
                                break;
                            case "2":
                                Console.WriteLine("You've chosen option 2.\n");
                                break;
                            case "3":
                                Console.WriteLine("You've chosen option 3.\n");
                                break;
                            case "4":
                                Console.WriteLine("You've chosen option 4.\n");
                                break;
                            default:
                                Console.WriteLine("Please select a valid number choice.\n");
                                break;
                        }
        }
}

    
