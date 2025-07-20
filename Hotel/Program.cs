using System;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guest[] guest = new Guest[10];

            Console.Write("How many rooms will be rented? ");
            int rentedRooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rentedRooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + i + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                guest[room - 1] = new Guest(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Occupied rooms:");         
            for (int i = 0; i < 10; i++)
            {
                if (guest[i] != null)
                {
                    Console.WriteLine((i + 1) + ": " + guest[i]);
                }
            }            
        }
    }
}
