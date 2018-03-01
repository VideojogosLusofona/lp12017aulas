using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {

            // I have Tank and Damage roles
            WoWRoles myRoles = WoWRoles.Tank | WoWRoles.Damage;

            // Am I a healer?
            if ((myRoles & WoWRoles.Healer) == WoWRoles.Healer)
            {
                Console.WriteLine("I heal you!");
            }
            else
            {
                Console.WriteLine("I DON'T heal you!");
            }

            // Show my current roles
            Console.WriteLine(myRoles);

            // Deactivate Tank role
            myRoles &= ~WoWRoles.Tank;

            // Toggle (switch) Healer role
            myRoles ^= WoWRoles.Healer;

            // Show my current roles
            Console.WriteLine(myRoles);

        }
    }
}
