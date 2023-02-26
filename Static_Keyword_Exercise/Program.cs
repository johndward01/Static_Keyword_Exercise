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
            var instance = new InstanceClassExample();
            instance.age = 10;
            instance.Name = "Instance Example";

            StaticClassExample.age = 20;
            StaticClassExample.Name = "Static Example";

            // TODO: Call BOTH of the PrintInfo() methods
            instance.PrintInfo();
            StaticClassExample.PrintInfo();

            // TODO: Instanciate 4 Players and assign values to the properties
            var scout = new Player()
            {
                Health = 500,
                Stamina = 100,
                Mana = 250,
            };
            var tank = new Player()
            {
                Health = 2000,
                Stamina = 750,
                Mana = 0
            };
            var mage = new Player()
            {
                Health = 300,
                Stamina = 500,
                Mana = 4000
            };
            var noob = new Player()
            {
                Health = 200,
                Stamina = 200,
                Mana = 200,
            };

            // TODO: Print the total player count using the playerCount field in the PlayerManager class
            Console.WriteLine($"The Total Player Count is: {PlayerManager.playerCount}");
        }
    }

    public class Player
    {
        public float Health { get; set; }
        public float Stamina { get; set; }
        public float Mana { get; set; }

        public Player()
        {
            // TODO: increment the playerCount field in the PlayerManager Class
            PlayerManager.playerCount++;
        }

        public Player(float health, float stamina, float mana)
        {
            // TODO: increment the playerCount field in the PlayerManager Class
            PlayerManager.playerCount++;
            Health = health;
            Stamina = stamina;
            Mana = mana;
        }
    }

    public static class PlayerManager
    {
        public static int playerCount; 
    }
}
