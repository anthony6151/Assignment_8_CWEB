using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyProgram
{
    public class Survey
    {
        static void Main(string[] args)
        {

            welcomeMessage();
            navQuestion();
            flowQuestion();
            visualQuestion();
            feedBack();

        }
        public static void welcomeMessage()
        {
            string name;
            Console.WriteLine("Thank you for visiting our site!  We are currently seeking feedback on our website and would like you to take a moment to complete this brief survey.  Please enter your name or alias: ");
            name = Console.ReadLine();
        }

        public static void navQuestion()
        {
            int rating;
            Console.WriteLine("On a scale from 0(worst) to 10(best), how easy was it to navigate the site?  Were you able to find the information you were looking for?  Please leave any applicable comments.");
            rating = Convert.ToInt32(Console.ReadLine());
            while (rating > 10)
            {
                Console.WriteLine("Please enter a number between 1 and 10");
                rating = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void flowQuestion()
        {
            int rating;
            Console.WriteLine("On a scale form 0(worst) to 10(best), how would you rate the overall flow of the site.  Was it easy to follow the content throughout the site?  Please leave any applicable comments at the end of the .");
            rating = Convert.ToInt32(Console.ReadLine());
            while (rating > 10)
            {
                Console.WriteLine("Please enter a number between 1 and 10");
                rating = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void visualQuestion()
        {
            int rating;
            Console.WriteLine("On a scale form 0(worst) to 10(best), how would you rate the visual appearance of the website.  Is it visually appealing?  Does the color scheme match the initial feel of the website?");
            rating = Convert.ToInt32(Console.ReadLine());
            while (rating > 10)
            {
                Console.WriteLine("Please enter a number between 1 and 10");
                rating = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void feedBack()
        {
            string comments;
            Console.WriteLine("Thank you again for visiting our site!  Please leave comments here: ");
            comments = Console.ReadLine();
        }
    }
}