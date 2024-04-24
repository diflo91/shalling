using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Etudiant
{
    public class MainStudentMenu : MenuAttribute
    {
        public string _MenuPrincipalEtudiant() 
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
            Console.Write("Veuillez choisir l'option : ");

            OptionMenuEleve = Console.ReadLine() ?? "";

            return OptionMenuEleve;
        }
    }
}
