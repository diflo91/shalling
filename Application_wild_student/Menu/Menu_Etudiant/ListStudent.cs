using Application_wild_student.Eleve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Etudiant
{
    public class ListStudent : MenuAttribute
    {
        public void _ListerEleve() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GlobalAttribute.wildStudent);
            Eleves eleves = new Eleves();
            eleves.ListerEleve();
            Console.Read();
            MainStudentMenu retourMenuPrincipal = new MainStudentMenu();
            retourMenuPrincipal._MenuPrincipalEtudiant();
        }
    }
}
