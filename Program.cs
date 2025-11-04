using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main()
    {
        //MAIN MENU
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";

        int op = 0;
        bool validInput;

        //CHAPTER ONE
        const string ChOneTitle = "===== CHAPTER ONE =====";
        const string ChOneBegin = "Welcome to the arcane academy! Let's start training your magic power in the next 5 days.";
        const string ChOneName = "Please choose your wizard name (max of 15 characters):";
        const string PowerNoob = "You are weak, you think that spoons are the same that magic wands...";
        const string PowerPro = "Almost there! At least you can conjure little magic breezes...";
        const string PowerHacker = "Yeah! your power is pretty impressive! you can invoke all sorts of dragons and conjure different spells.";
        const string PowerGod = "Congratulations! your power is worth of an arcane master! Your knowldedge is unlimited.";
        const string NameError = "Invalid name, please input a name with at least one character and shorter than 15 characters.";

        const string LevelNoob = ", The Bread Head, That's your level.";
        const string LevelPro = " Peppermint, That's your level.";
        const string LevelHacker = ", The red magician, That's your level.";
        const string LevelGod = ", Jujutsu of Oblivion, That's your level.";

        string? name;
        var randomNum = new Random();
        int totalPow = 0;
        int actualPow = 0;

        //CHAPTER TWO
        const string ChTwoTitle = "===== CHAPTER TWO =====";
        const string ChTwoBegin = "Benvingut poderos mag! Acabes d'entrar dins el calabos del temible drac RAMon... Encerta tots els codis de les 3 portes i guanyaras!";
        const string DoorMsg = "Inserta un nombre del 1 al 5, estas a la porta numero: ";
        const string DoorPass = "El drac et respecta. Has desbloquejat el següent nivell!";
        const string DoorWrong = "Codi incorrecte! Rapid, Prova amb un altre, que nomes et queda/en aquest/s intent/s: ";
        const string DoorDeath = "El drac ha detectat la teva presència i t’ha expulsat del servidor!";
        const string DoorFinal = "Has desbloquejat el nivell final. Prepara’t per la batalla!";
        const string DoorError = "Has trencat el candau... aixo ha alertat al drac RAMon, recorda que NOMES POTS POSAR UN NOMBRE DEL 1 AL 5!";

        var randomNum2 = new Random();
        int code = 0; 
        int num;
        bool stupid = false;

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                validInput = false;
            }
            catch (Exception)
            {
                validInput = false;
            }

            if (op > 3 || op < 0)
            {
                validInput = false;
            }
            else
            {
                validInput = true;
            }

            if (validInput)
            {
                Console.WriteLine(op);
            }
            else 
            {
                Console.WriteLine(InputErrorMessage);
            }



            if (op == 1)
            {
                //CHAPTER 1:
                Console.WriteLine(ChOneTitle);
                Console.WriteLine(ChOneBegin);
                Console.WriteLine(ChOneName);
                name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(name) || name.Length > 15)
                {
                    while (String.IsNullOrWhiteSpace(name) || name.Length > 15)
                    {
                        Console.WriteLine(NameError);
                        name = Console.ReadLine();
                    }
                }

                for (int i = 1; i <= 5; i++)
                {
                    actualPow = randomNum.Next(1, 10);
                    Console.WriteLine("--DAY " + i + ": you meditated 10 hours, you gained " + actualPow + " power points!");
                    totalPow += actualPow;
                    Console.WriteLine("Actual power: " + totalPow + " press ENTER to continue");
                    Console.ReadLine();
                }

                switch (totalPow)
                {
                    case <= 20:
                        Console.WriteLine(PowerNoob);
                        Console.WriteLine(name + LevelNoob);
                        break;
                    case <= 30:
                        Console.WriteLine(PowerPro);
                        Console.WriteLine(name + LevelPro);
                        break;
                    case <= 40:
                        Console.WriteLine(PowerHacker);
                        Console.WriteLine(name + LevelHacker);
                        break;
                    case <= 47:
                        Console.WriteLine(PowerGod);
                        Console.WriteLine(name + LevelGod);
                        break;
                    default:
                        Console.WriteLine(PowerGod);
                        Console.WriteLine(name + LevelGod);
                        break;

                }

            }
            else if (op == 2) 
            {
                //CHAPTER 2
                Console.WriteLine(ChTwoTitle);
                Console.WriteLine(ChTwoBegin);
                for (int i = 1; i <= 3; i++) 
                {
                    Console.WriteLine(DoorMsg + i);
                    code = randomNum2.Next(1,5);
                    num = Int32.Parse(Console.ReadLine());
                    if (num <= 0 || num > 5) 
                    {
                        Console.WriteLine(DoorError);
                        stupid = true;
                    }
                    for (int j = 2; j > 0 && num != code && stupid == false; j--) 
                    {
                        Console.WriteLine(DoorWrong + j);
                        num = Int32.Parse(Console.ReadLine());
                    }
                    if (num != code && stupid == true)
                    {
                        Console.WriteLine(DoorDeath);
                        i = 4;
                        op = 0;
                    }
                    else 
                    {
                        Console.WriteLine(DoorPass);
                    }

                }
                if (op != 0) 
                {
                    Console.WriteLine(DoorFinal);
                }
            }

        } while (op != 0);
    }
}