using System;

namespace Static_Keyword_Exercise
{
    public class InstanceClassExample
    {
        public int age;                   // Field
        public string Name { get; set; } // Property
        public void PrintInfo()         // Method
        {
            Console.WriteLine($"Name: {Name}\tAge: {age}");
        }
    }

    public static class StaticClassExample
    {
        public static int age;                   // Field
        public static string Name { get; set; } // Property
        public static void PrintInfo()         // Method
        {
            Console.WriteLine($"Name: {Name}\tAge: {age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Set the values for the Fields and Properties of the Instance Class Example and the Static Class Example
            // TODO: Call BOTH of the PrintInfo() methods

            // TODO: Instanciate 4 Players and assign values to the properties
            // TODO: Print the total player count using the playerCount field in the PlayerManager class
        }
    }

    public class Player
    {
        public float Health { get; set; }
        public float Stamina { get; set; }
        public float Mana { get; set; }

        public Player()
        {
            // TODO:
        }

        public Player(float health, float stamina, float mana)
        {
            // TODO:
            Health = health;
            Stamina = stamina;
            Mana = mana;
        }
    }

    public class PlayerManager
    {
        public int playerCount; 
    }
}
