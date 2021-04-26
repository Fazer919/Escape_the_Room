using System;
using System.Threading;
namespace Escape_the_Room
{
   public class Program
    { 
        static void Main(string[] args)
        {
            Encounters x = new Encounters();
            Player p = new Player();

            Console.WriteLine("There are 3 people in the room you must try and escape by answering a few questions.");
            Console.Write("Please wright your name:");
            string name = Console.ReadLine();
            if(name=="")
            {
                Console.WriteLine("You relize you have forgotten your name...");
            }
            else
            {
                Console.WriteLine("Your name is " + name);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are in a mysterious room.You have no recollection of who you are but you know that your answer's wait for you outside of the room.");
            Console.WriteLine("Do you (A) go and try and open the door or do you (B) look around the room");
            string option1 = Console.ReadLine();
            option1=option1.ToUpper();
            string starting = "You look around the room you find 1 man sitting by the fire he looks around the age of 70. 1 man sharpining his sword who looks around the age of 50.And a woman who looks around the age of 25 and has a few scars on her neck as if she just came out of battle.";
            if (option1 == "B")
            {
                Console.WriteLine(starting);
            }
            else if(option1=="A")
            {
                Console.WriteLine("You go to the door and tug on it until you feel like your arms are going to fall off but still the door is not budging." + starting);
            }
            else
            {
                Console.WriteLine("Why did you just try and cheat!You nimrod get out of my game.This game will make you suffer if you are a hacker.");
                Console.WriteLine("So let me save you from the pain and suffering that you will go thorough if you continue playing the game");
                System.Environment.Exit(0);
            }


            while (true)
            {
                Console.WriteLine("Who do you want to talk to? (A) Do you wanna talk to the guy sitting by himself.(B)Do you wanna talk to the woman.(C)Do you wanna talk to the man sharpening his sword.(D) Do you wanna try and go open the door again.");
                string people = Console.ReadLine();
                people = people.ToUpper();
                if (people == "A")
                {
                    Console.Clear();
                    x.FirstEncounter();
                    p.coins += 33;
                    Console.WriteLine("Coins: " + p.coins);
                }
                else if (people == "B")
                {
                    Console.Clear();
                    x.SecondEncounter();
                    p.coins += 34;
                    Console.WriteLine("Coins: " + p.coins);
                }
                else if (people == "C")
                {
                    Console.Clear();
                    x.ThirdEncounter();
                    p.coins += 33;
                    Console.WriteLine("Coins:" + p.coins);
                }
                else if (people == "D" && p.coins == 100)
                {
                    Console.Clear();
                    Console.WriteLine("You walk up to the door once again and put the coins on the ground near the wall.");
                    Console.WriteLine("The door suddenly opens as you tug on it.It seems like magic but it feels like you did not have to even touch the door and it would have oppened.");
                    Console.WriteLine("As the door openes you feel metal in your stomach.And you turn around...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You Win.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (people =="D"&&p.coins!=100)
                {
                    Console.WriteLine("You walk up to the door and still it does not budge no matter what you do.");
                    Console.WriteLine("You really want to get out of this room but the door is not budging.");
                    Console.WriteLine("Console:Please go and talk to more people to get some cash");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
