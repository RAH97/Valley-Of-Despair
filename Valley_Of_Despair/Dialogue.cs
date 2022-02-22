using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valley_Of_Despair
{
    public class Dialogue
    {
        public void MountStupidDialogue()
        {

            Console.Clear();
            Console.WriteLine("It was a sunny day on the top of Mount Stupid, you are writing SELECT statements and feeling great about yourself.");
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
            
            Console.WriteLine("A heavy wind blew as you tried to remember how to write a subquery...you fall several stories ");
            Console.WriteLine("As you regain consciousness, the code...I mean air...smells...smelly. ");
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
           
            Console.WriteLine("Follow the smell?");
            Console.WriteLine("(1) yes");
            Console.WriteLine("(2) no, can I get back to my nap now?");
        }
        public void ReadMeDeath()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("A READ_ME appears...");
            Console.WriteLine("The READ_ME exposes you to a form of english so incomprehensible that your mere mortal mind descends into an inescapeable madness...");
            Console.WriteLine("You remain at the base of Mount Stupid, cradling yourself as you try to figure out if you should create a new Paint Calculator, or if one has been made for you.. ");
            Console.WriteLine("If only you made some kind of attempt to find a weapon or train for this fight...");
            Console.WriteLine("Slowly... you feel yourself contort, until you have become another READ_ME, forced to carry out the same torment that birthed your new form..");
            Console.WriteLine();
            Console.WriteLine();
            IASCIIable.GameOver();
            Console.WriteLine("Press enter to quit...loser.");
            Console.ReadLine();
        }
        public void CharacterSelect()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("A weird voice that seems to come from nowhere asks:");
            Console.WriteLine("Be YoU a WaRrIoR, a MaGe, Or A rOgUe?");
            Console.WriteLine("(1) Warrior");
            Console.WriteLine("(2) Mage");
            Console.WriteLine("(3) Rogue");
            Console.ForegroundColor = ConsoleColor.White;
           
        }
        public void WarriorMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ooh, a big dummy, classic you.");
            Console.WriteLine("Press any key to continue...");
            
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void MageMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ah a mage...how realistic.");
            Console.WriteLine("Press any key to continue...");
           
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void RogueMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("I always knew I shouldn't leave my wallet around you.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void EnterName()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What is your name? No I'm not hitting on you!...unless...");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void SmellyMoss()
        {
            Console.WriteLine("Following the smell eh? Is that how you met your partner?");
            Console.WriteLine("Anyways...");
            Console.WriteLine("You travel down a cobblestone road that begins right where you landed... how convenient.");
            Console.WriteLine("the moss covering the stone is alive");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Moss: Eat me, you need more green in your diet by the looks of ya.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) Eat the moss.");
            Console.WriteLine("(2) Decline the moss's generous offer. ");
            Console.WriteLine("(3) Ask the moss why it wants you to eat it.");
        }
        public void EatTheMoss()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Why would you eat moss? Just because we told you to?");
            Console.WriteLine("Moss(In your stomach): you fool!");
            Console.WriteLine("You begin to halluciinate compiler errors under all of your code. You delete your OS in an attempt to escape the...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Critical Error: file: Windows.OS Not Found");
            IASCIIable.GameOver();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to quit...loser");
            Console.ReadLine();
        }
        public void DontEatMoss()
        {
            Console.WriteLine("You decide not to eat the moss.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Moss: Fine, don't eat me, I don't care...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You also realize that the passive-aggresive moss shouldn't be talking at all...");
            Console.WriteLine("You definitely have head trauma.");
            Console.WriteLine("Press any key to continue...");
        }
        public void TalkToMoss()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Moss:...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Yeah you're hallucinating (-1 Sanity)");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        public void WalkToTown()
        {
            Console.WriteLine("You walk further down the road until you see lights in the distance...there's a town about half a mile down the road...");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Once you arrive at the gate protecting the town, you notice a small wooden kiosk...");
            Console.WriteLine("A man peeks his head out from under the counter");
            Console.WriteLine("...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You're not one of them are you?...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(1) Where am I?");
            Console.WriteLine("(2) Who, the moss?");
            

        }
        
        public void Shop1Dialogue()
        {
            Console.WriteLine("Fine... I've got a beer thats been in my cooler for two months and some weapons.");
            Console.WriteLine("                ╔══════════════════════════|Town Shop|══════════════════════════╗");
            Console.WriteLine("                ║                                                               ║");
            Console.WriteLine("                ║          (1)SQ-Ale (+3 sanity, -1 defense) -5 gold            ║");
            Console.WriteLine("                ║     (2)Merge Error Mutilator(Axe)(+6 attack) -30 gold         ║");
            Console.WriteLine("                ║ (3)Ryan's Rollback(Wand)(+2 attack, +4 intelligence)- 30 gold ║");
            Console.WriteLine("                ║   (4)Read_Me's Bane (+4 attack, +2 intelligence)- 30 gold     ║");
            Console.WriteLine("                ║                                                               ║");
            Console.WriteLine("                ╚═══════════════════════════════════════════════════════════════╝");
        }
        public void CharacterDialogue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void PassiveNonPlayerDialogue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
