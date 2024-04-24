using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Etudiant
{
    public class ErrorChoiceSelection : MenuAttribute
    {
           public void _ErreurDeSelection()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.Write("    ");
            Console.Write("Saisissez les options disponibles, Appuyez enter pour continuer : ... ");
            Console.ResetColor();
            OptionMenuEleve = Console.ReadLine() ?? "";
            isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);
        }

        public void _ErrorNumberOnly()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GlobalAttribute.wildStudent);
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.Write("    ");
            Console.WriteLine("[1]. Lister les élèves ");
            Console.Write("    ");
            Console.WriteLine("[2]. Créer un nouvel élève");
            Console.Write("    ");
            Console.WriteLine("[3]. Consulter un élève existant");
            Console.Write("    ");
            Console.WriteLine("[4]. Ajouter une note et une appréciation pour un cours sur un élève existant");
            Console.Write("    ");
            Console.WriteLine("[5]. Revenir au menu principal");
            Console.WriteLine("");
            Console.Write("    ");
            Console.WriteLine("Veuillez choisir l'option : ");

            Console.WriteLine();
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("! Veuillez saisir un nombre, appuyez sur enter pour continuer : .... ");
            Console.ResetColor();
            OptionMenuEleve = Console.ReadLine() ?? "";
            isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);
        }
    }
}
