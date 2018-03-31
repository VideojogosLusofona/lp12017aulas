using System;

// Fully documented version of this exercise available at
// http://starboundsoftware.com/books/c-sharp/try-it-out/designing-and-building-classes
namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two different balls of different colors and sizes.
            Ball bigRed = new Ball(new Color(255, 0, 0), 5);
            Ball littlePurple = new Ball(new Color(255, 0, 255), 3);

            // Throw the big red ball around a few times.
            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            // Keep throwing it, and make sure that the number of
            // times thrown keeps going up.
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            // Throws the little purple ball around.
            littlePurple.Throw();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());

            // Pop the little purple ball and make sure that the throw
            // count doesn't keep going up if the ball has been popped.
            littlePurple.Pop();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());
        }
    }
}
