using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Valley_Of_Despair
{
    public class User_Interface : IASCIIable
    {

        public static void MainMenu()
        {
            Character Rogue = new Character(15, 20, 30, 20);
            Character Mage = new Character(25, 10, 30, 15);
            Character Warrior = new Character(20, 20, 30, 10);
            Dialogue dialogue = new Dialogue();
            string mainMenuChoice = " ";
            IASCIIable.MainMenuArt();

            do
            {
                Console.WriteLine("(1) New Game");
                Console.WriteLine("(2) Exit");
                mainMenuChoice = Console.ReadLine();
                if (mainMenuChoice == "1")
                {
                    Console.Clear();
                    dialogue.CharacterSelect();
                    string characterSelectChoice = Console.ReadLine();
                    string userName = "";
                    if (characterSelectChoice == "1")
                    {
                        // Console.Clear();
                        dialogue.WarriorMessage();
                        dialogue.EnterName();
                        userName = Console.ReadLine();
                        Warrior.Name = userName;
                    }
                    else if (characterSelectChoice == "2")
                    {
                        // Console.Clear();
                        dialogue.MageMessage();
                        dialogue.EnterName();
                        userName = Console.ReadLine();
                        Mage.Name = userName;
                    }
                    else if (characterSelectChoice == "3")
                    {
                        // Console.Clear();
                        dialogue.RogueMessage();
                        dialogue.EnterName();
                        userName = Console.ReadLine();
                        Rogue.Name = userName;
                    }

                    dialogue.MountStupidDialogue();
                    string userChoice1 = Console.ReadLine();

                    if (userChoice1 == "1")
                    {
                        Console.Clear();
                        dialogue.SmellyMoss();
                        string userSmellyMossChoice = Console.ReadLine();
                        if (userSmellyMossChoice == "1")
                        {
                            Console.Clear();
                            dialogue.EatTheMoss();
                            return;
                        }
                        else if (userSmellyMossChoice == "2")
                        {
                            Console.Clear();
                            dialogue.DontEatMoss();
                        }
                        else if (userSmellyMossChoice == "3")
                        {
                            Console.Clear();
                            if (characterSelectChoice == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Warrior.Name}: Why do you want me to eat you?");
                                Console.ForegroundColor = ConsoleColor.White;
                                Warrior.Sanity--;
                                dialogue.TalkToMoss();
                                Console.Clear();
                            }
                            else if (characterSelectChoice == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Mage.Name}: Why do you want me to eat you?");
                                Console.ForegroundColor = ConsoleColor.White;
                                Mage.Sanity--;
                                dialogue.TalkToMoss();
                                Console.Clear();
                            }
                            else if (characterSelectChoice == "3")
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"{Rogue.Name}: Why do you want me to eat you? *looks for loose change in Moss's pockets*");
                                Console.ForegroundColor = ConsoleColor.White;
                                dialogue.TalkToMoss();
                                Rogue.Sanity--;
                                Console.Clear();
                                
                            }
                        }
                        string walkToTownUserChoice = "";
                        do
                        {
                            dialogue.WalkToTown();
                            walkToTownUserChoice = Console.ReadLine();
                            if (walkToTownUserChoice == "1")
                            {
                                if (characterSelectChoice == "1")
                                {
                                    dialogue.CharacterDialogue($"{Warrior.Name}: Where am I?");
                                    dialogue.PassiveNonPlayerDialogue($"The Valley of Despair... didn't you see the signs?");
                                    dialogue.CharacterDialogue($"{Warrior.Name}: No...anyways can I take a look at your inventory?");
                                    dialogue.PassiveNonPlayerDialogue("I don't have any steroids...");
                                    dialogue.CharacterDialogue($"{Warrior.Name}(Angrily): I don't take steroids!");
                                    dialogue.PassiveNonPlayerDialogue($"Oh...you look like you do.");
                                    dialogue.CharacterDialogue($"{Warrior.Name}: are you going to sell me something or not?");
                                    dialogue.Shop1Dialogue();
                                    break;
                                }
                                if (characterSelectChoice == "2")
                                {
                                    dialogue.CharacterDialogue($"{Mage.Name}: Where am I? ");
                                    dialogue.PassiveNonPlayerDialogue($"The Valley of Despair... didn't you see the signs?");
                                    dialogue.CharacterDialogue($"{Mage.Name}: No...anyways can I take a look at your inventory?");
                                    dialogue.PassiveNonPlayerDialogue($"Sure, but I don't sell potions, there's a serious addiction problem here.");
                                    dialogue.CharacterDialogue($"{Mage.Name}: *scratches neck violently* Well tell me what you do have then.");
                                    dialogue.Shop1Dialogue();
                                    break;

                                }
                                if (characterSelectChoice == "3")
                                {
                                    dialogue.CharacterDialogue($"{Rogue.Name}: Where am I? ");
                                    dialogue.PassiveNonPlayerDialogue($"The Valley of Despair... didn't you see the signs?");
                                    dialogue.CharacterDialogue($"{Rogue.Name}: No...do you carry lockpicks?");
                                    dialogue.PassiveNonPlayerDialogue($"Oh great another hoodlum in town...No I don't.");
                                    dialogue.CharacterDialogue($"{Rogue.Name}: Thieve's code prevents me from using it on you... while you're watching at least.");
                                    dialogue.Shop1Dialogue();

                                    break;
                                }
                            }
                            else if (walkToTownUserChoice == "2")
                            {
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Stop trying to break my game, troll.");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.ResetColor();
                                Console.Clear();

                            }
                        }
                        while (walkToTownUserChoice != "1" || walkToTownUserChoice != "2");

                    }
                    if (userChoice1 == "2")
                    {
                        dialogue.ReadMeDeath();

                        return;
                    }



                }
                else if (mainMenuChoice != "2" && mainMenuChoice != "2")
                {
                    Console.WriteLine("Excuse me...we have rules here. Press 1 or 2.");
                }

            }
            while (mainMenuChoice != "2");












        }






    }
}
