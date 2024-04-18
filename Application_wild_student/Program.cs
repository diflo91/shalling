using System.Drawing;

namespace Application_wild_student
{
    public class Program
    {

        public static string wildStudent = @"
    ███████╗██╗  ██╗ █████╗ ██╗     ██╗     ██╗███╗   ██╗ ██████╗ 
    ██╔════╝██║  ██║██╔══██╗██║     ██║     ██║████╗  ██║██╔════╝ 
    ███████╗███████║███████║██║     ██║     ██║██╔██╗ ██║██║  ███╗
    ╚════██║██╔══██║██╔══██║██║     ██║     ██║██║╚██╗██║██║   ██║
    ███████║██║  ██║██║  ██║███████╗███████╗██║██║ ╚████║╚██████╔╝
    ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                          Developped by Fleury
    ----------------------------------------------------------------------------------------------------------";

        public static bool Correct = false;
        public static int ChoixOptionInt;
        public static string ChoixOption;


        static void Main(string[] args)
        {
           

            while (true)
            {
                // Console.Clear();

                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(wildStudent);
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("    ");
                
                Console.WriteLine("1. Elève ");
                Console.Write("    ");
                Console.WriteLine("2. Cours");
                Console.WriteLine("");
                Console.Write("    ");
                Console.Write("Veuillez choisir l'option : ");

             

                ChoixOption = Console.ReadLine();
                Correct = int.TryParse(ChoixOption, out ChoixOptionInt);

               

               while (!Correct)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(wildStudent);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("    ");
                    Console.WriteLine("1. Elève ");
                    Console.Write("    ");
                    Console.WriteLine("2. Cours");
                    Console.WriteLine("");
                    Console.Write("    ");
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.Write("Saisie invalide. Veuillez saisir un nombre : ");
                    Console.ResetColor();
                    ChoixOption = Console.ReadLine();
                    Correct = int.TryParse(ChoixOption, out ChoixOptionInt);
                } 


               if (ChoixOption == "1" && Correct)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(wildStudent);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.Write("    ");
                        Console.WriteLine("1");
                        Console.Read();
                    }
                
                } else if (ChoixOption == "2" && Correct)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(wildStudent);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.Write("    ");
                        Console.WriteLine("1");
                        Console.Read();
                    }

                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.Write("    ");
                    Console.Write("Saisissez les options disponibles, Appuyez enter pour continuer : ... ");
                    Console.ResetColor();
                    ChoixOption = Console.ReadLine();
                    Console.Clear() ;   
                }



            }
        }
    }
}
