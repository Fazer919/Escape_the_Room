using System;
namespace Escape_the_Room
{
    public class Encounters
    {
        public void FirstEncounter()
        {
            Console.WriteLine("You walk up to the man that is sitting by the fire alone as you feel he need's company.");
            Console.WriteLine("When you sit down he asks you a question.");
            Console.WriteLine("The question is a multiplication question.");
            Console.WriteLine("What is 900*2.");
            Console.WriteLine("He gives you 3 choices one of them shall end up leading to another question which will become a 3 layered test.");
            Console.WriteLine("Choice (A) 1800. Choice (B) 1700. Choice(C)6000");
            string test_question1 = Console.ReadLine();
            test_question1 = test_question1.ToUpper();
            if (test_question1 == "A")
            {
                Console.WriteLine("Console:Correct");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Old Timer:Alright good job young lad.The next question will be even harder.The question is are u a loser?");
                Console.WriteLine("Console:(A) yes I am a loser or (B) i am not a loser I am very smart or (C) depends on the time of day.");
                string test_question2 = Console.ReadLine();
                test_question2 = test_question2.ToUpper();
                if (test_question2 == "A")
                {
                    Console.WriteLine("Old Timer:Whats wrong with u are not stupid are you ok young lad.");
                    Console.WriteLine("Here I feel bad you may have the coins that are necceray for getting out of the room");
                }
                else if (test_question2 == "B")
                {
                    Console.WriteLine("Old Timer:You are lying young lad.");
                    System.Environment.Exit(0);
                }
                else if (test_question2 == "C")
                {
                    Console.WriteLine("Old Timer:You are correct you may move on to the next question lad.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Old Timer:You find a cave one way is very dark and one is verry light up.Which way do you go.");
                    Console.WriteLine("Console:(A) is the light up way and (B) is the dark path.");
                    string test_question3 = Console.ReadLine();
                    test_question3 = test_question3.ToUpper();
                    if (test_question3 == "A")
                    {
                        Console.WriteLine("Old Timer:You find a dead body which ends up coming back to life and taking the dead body takes a sword and kills you.");
                        Console.WriteLine("Old Timer:This choice is Incorrect.");
                        System.Environment.Exit(0);
                    }
                    else if (test_question3 == "B")
                    {
                        Console.WriteLine("Old Timer:Correct.");
                        Console.WriteLine("Old Timer:I thought I could get u.U win good job this should help you get out of the room.He hands you 33 coins.");
                    }
                    else
                    {
                        Console.WriteLine("Stop trying to cheat");
                        System.Environment.Exit(0);
                    }
                }

            }
            else if (test_question1 == "B")
            {
                Console.WriteLine("Console:Incorrect");
            }
            else if (test_question1 == "C")
            {
                Console.WriteLine("Console:Incorrect");
            }
            else
            {
                Console.WriteLine("Stop cheating you cheater.");
                System.Environment.Exit(0);
            }
        }
    public void SecondEncounter()
        {
            Console.WriteLine("You go and walk up to the lady because you want to ask her how she got all those scars on her body and when was the last time she was in the battle field.");
            Console.WriteLine("Woman Fighter:Plz go away I do not want to talk to you.");
            Console.WriteLine("I want to talk to you though because I want to get out of this room.");
            Console.WriteLine("Woman Fighter:Fine I will help but you must answer my questions is that cool with you?");
            Console.WriteLine("Sure");
            Console.WriteLine("Woman Fighter:What is better for blocking (A) sword or (B) shield");
            string defense = Console.ReadLine();
            defense = defense.ToUpper();
            if (defense == "A")
            {
                Console.WriteLine("Console:You are incorrect because A would be harder to block stuff with.");
                System.Environment.Exit(0);
            }
            else if(defense=="B")
            { 
                Console.Clear();
                Console.WriteLine("Console:You are correct because of the fact that it is easier to block with a shield than a sword.");
                Console.WriteLine("Woman Fighter:Good job though I have 2 more questions that are even harder than the first one.");
                Console.WriteLine("Woman Fighter:What is better to kill people with (A) bow and arrow (B) Ar (C) Sniper rifle(D) Depends on how far you are to your oppenent.");
                string kill = Console.ReadLine();
                kill = kill.ToUpper();
                if (kill == "D")
                {
                    Console.Clear();
                    Console.WriteLine("Console:Yes it depends on how far you are because if you are very close ar is a good option if the guy is medium range then bowing them is a easy thing and if they are far range then sniper rifle is a good idea.");
                    Console.WriteLine("Console:This choice is correct.");
                    Console.Clear();
                    Console.WriteLine("Woman Fighter:Ok last question.For a string what is A string plus B string.");
                    Console.WriteLine("Console:(A) AB (B) C");
                    string adding_string = Console.ReadLine();
                    adding_string = adding_string.ToUpper();
                    if (adding_string == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("Console:This choice is correct because of the fact that strings just represent characters so it will just combine the character's into what the 2 character both are.");
                        Console.WriteLine("Woman Fighter:Ok since you got these answers correct here is 34 coins I added 1 just for being cute.");
                    }
                    else if (adding_string == "B")
                    {
                        Console.Clear();
                        Console.WriteLine("This choice is incorrect because what strings do basically is the fact that they just represent characters and so all that would happen is the characters would just converge together to become AB.");
                        System.Environment.Exit(0);
                    }
                }
                else if (kill == "A")
                {
                    Console.WriteLine("This choice is incorrect because sniper rifle's are easier to use at long range.");
                    System.Environment.Exit(0);
                }
                else if (kill == "B")
                {
                    Console.WriteLine("This choice is incorrect because sniper rifles's are easier to use at long range.");
                    System.Environment.Exit(0);
                }
                else if (kill == "C")
                {
                    Console.WriteLine("This choice is incorrect because of the fact that Ar's are really good at medium range and bow and arrow are very good at low range capacity");
                    System.Environment.Exit(0);
                }
            }
        }
        public void ThirdEncounter()
        {
            Console.WriteLine("you walk up to the man because of the fact that you want to learn how to sharpen a sword for future referance if you ever need it.");
            Console.WriteLine("Sharpener: Hey bro plz leave me alone I need to concentrate on getting out of this stupid room.");
            Console.WriteLine("What wrong with u I just want to get out of this room.");
            Console.WriteLine("Sharpener: Fine I will help u get out of the room you need to answer a few of my questions.");
            Console.WriteLine("Fine I will agree to answer a few of your questions but then you will help me get out of this stupid room I am getting very annoyed.");
            Console.WriteLine("Sharpener: Is magic real");

            //First Question
            string magic;

            Console.WriteLine("Console: (A) Magic is real (B) Magic is not real.");
            magic = Console.ReadLine();
            magic=magic.ToUpper();

            if(magic != "A" && magic != "B")
            {
                do
                {
                    Console.WriteLine("It seems like you typed something wrong.");
                    Console.WriteLine("Here is the question again if you missed it (A) Magic is real (B) Magic is not real.");
                    magic = Console.ReadLine();
                } while (magic != "A" && magic != "B");
            }
            

            //First Question Answer

            if (magic == "A")
            {
                Console.WriteLine("Magic is not real it is just the confusion of the mind.");
                System.Environment.Exit(0);
            }
            else if (magic == "B")
            {
                Console.WriteLine("Sharpener:You are correct magic is not real.");
                Console.WriteLine("Sharpener:Next question what is 8+10");
            }

            //Second Question

            string Math_Brain;

            Console.WriteLine("(A) 18 (B) 20 (C) 2");
            Math_Brain = Console.ReadLine();
            Math_Brain = Math_Brain.ToUpper();

            if (Math_Brain != "A" && Math_Brain != "B" &&  Math_Brain != "C")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("You seemed to have typed something wrong please try again.");
                    Console.WriteLine("Here is the question again if you missed it (A) 18 (B) 20 (C) 2");
                    Math_Brain = Console.ReadLine();
                    Console.Clear();
                } while (Math_Brain != "A" && Math_Brain != "B" && Math_Brain != "C");
            }


            //Second Question Answer

            if(Math_Brain=="A")
            {
                Console.Clear();
                Console.WriteLine("Sharpener:You are correct that was supposed to be easy.");
                Console.WriteLine("Sharpener:This next question might be a little bit harder for you.");
                Console.WriteLine("Sharpener:Am I a boy or a girl");
                Console.ReadLine();
                Console.Clear();
            }
            else if(Math_Brain=="B")
            {
                Console.WriteLine("This choice is incorrect.");
                System.Environment.Exit(0);
            }
            else if(Math_Brain=="C")
            {
                Console.WriteLine("This choice is incorrect");
                System.Environment.Exit(0);
            }

            //Third Question

            string Last_Question;

            Console.WriteLine("(A) boy (B) girl.");
            Last_Question = Console.ReadLine();
            Last_Question = Last_Question.ToUpper();

            if(Last_Question=="A")
            {
                Console.WriteLine("Good job on paying attention to what it said before.");
                Console.WriteLine("Since you got it correct here you go.");
                Console.WriteLine("He hands you 33 gold coins.");
            }
            if(Last_Question=="B")
            {
                Console.WriteLine("Did you not even read the start you dummy.");
                Console.WriteLine("How did you freakin get it wrong.");
                System.Environment.Exit(0);
            }
        }
    }
}
