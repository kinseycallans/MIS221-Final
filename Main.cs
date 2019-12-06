using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PA5
{
    class PA5
    {
        static void Main(string[] args)
        {

            string userAnswer;

            MovieFile.myMovie = MovieFile.GetAllMovies();
            for(int i = 0; i < MovieFile.getCount(); i++)
            {
                Console.WriteLine(MovieFile.myMovie[i].getMovieTitle());
            }


            Movie m = new Movie();
            
            Console.WriteLine("Welcome to VideoMart! Are you a Customer or Manager? Write 1 for Custmer or 2 for Manager. \n");
            userAnswer = Console.ReadLine();
            if (userAnswer == "1")
            {
                Console.WriteLine("Customer Menu - Please select a number for the action you would like to choose: \n" +
                    "1: View movies available to rent \n" +
                    "2: Rent a Movie \n" +
                    "3: View your current rentals \n" +
                    "4: Return a Movie \n");
                userAnswer = Console.ReadLine();
                switch (userAnswer)
                {
                    case "1":
                        Console.WriteLine("You've chosen option 1.\n");
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
            else if (userAnswer == "2")
            {
                Console.WriteLine("Manager Menu - Please select a number for the action you would like to choose: \n" +
                    "1: Add movie to inventory \n" +
                    "2: Remove movie from inventory \n" +
                    "3: Edit movie characteristics \n" +
                    "4: Edit a batch transaction \n" +
                    "5: View the report menu \n");
                userAnswer = Console.ReadLine();
                switch (userAnswer)
                {
                    case "1":
                        Console.WriteLine("Please enter the title of the movie you would like to add.\n");
                        m.setMovieTitle(Console.ReadLine());
                        Console.WriteLine("Please enter the ID of the movie you would like to add.\n");
                        m.setMovieID(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Please enter the genre of the movie you would like to add. The choices are 'Action', 'Family', 'Horror', 'Sci-Fi', 'Comedy', or 'Other'. \n");
                        m.setMovieGenre(Console.ReadLine());
                        Console.WriteLine("Please enter the release year of the movie you would like to add in the format 'xxxx'.\n");
                        m.setReleaseYear(int.Parse(Console.ReadLine()));
                        m.setStock("Y");
                        MovieFile.AddMovie(m);
                        MovieFile.SaveMovie();
                        break;
                    case "2":
                        Console.WriteLine("Please enter the ID of the movie you would like to remove.\n");
                        userAnswer = Console.ReadLine();
                        MovieFile.RemoveMovie(userAnswer);
                        MovieFile.SaveMovie();
                        break;
                    case "3":
                        Console.WriteLine("Please enter the ID of the movie you would like to edit.\n");
                        userAnswer = Console.ReadLine();
                        Console.WriteLine("What field of " + userAnswer + " would you like to edit? Please select a number: \n" +
                            "1: Edit " + userAnswer + "'s movie title. \n" +
                            "2: Edit " + userAnswer + "'s movie ID. \n" +
                            "3: Edit " + userAnswer + "'s movie genre. \n" +
                            "4: Edit " + userAnswer + "'s release year. \n");
                        userAnswer = Console.ReadLine();
                        switch (userAnswer)
                        {
                            case "1":
                                Console.WriteLine("You've chosen option 1.\n");
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
                        break;
                    case "4":
                        Console.WriteLine("You've chosen option 4 (Batch Transaction).\n");
                        break;
                    case "5":
                        Console.WriteLine("Welcome to the Report Menu - Please select a number for the report you would like to run: \n" +
                            "1: Movies currently in stock \n" +
                            "2: Movies currently rented \n" +
                            "3: Number of rentals by genre \n");
                        userAnswer = Console.ReadLine();
                        switch (userAnswer)
                        {
                            case "1":
                                Console.WriteLine("You've chosen the 'Movies currently in stock' report.\n");
                                break;
                            case "2":
                                Console.WriteLine("You've chosen the 'Movies currently rented' report.\n");
                                break;
                            case "3":
                                Console.WriteLine("You've chosen the 'Number of rentals by genre' report.\n");
                                break;
                            default:
                                Console.WriteLine("Please select a valid number choice.\n");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Please select a valid number choice.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("That is not a valid choice. Please write 1 for Custmer or 2 for Manager. \n");
            }
            
        }
        
    }
    
}