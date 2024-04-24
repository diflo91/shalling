using Application_wild_student.Eleve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Etudiant
{
    public class CreateStudant : MenuAttribute
    {
        public void _CreerEleve() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GlobalAttribute.wildStudent);
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.Write("    ");
            Console.Write("Saisissez le nom : ");
            Console.Write("    ");
            string NomEleveSet = Console.ReadLine() ?? "";
            Console.Write("    ");
            Console.Write("Saisissez le prenom : ");
            Console.Write("    ");
            string PreNomEleveSet = Console.ReadLine() ?? "";
            Console.Write("    ");
            Console.Write("Saisissez la date de naissance : ");
            Console.Write("    ");
            string DateDeNaissanceEleveSet = Console.ReadLine() ?? "";
            Console.WriteLine("    ");
            Console.Write("    ");
            Console.Write("Saisissez vos notes et appreciations : ...");

            Console.WriteLine("    ");
            Console.Write("                   ");
            Console.Write("Saisissez le cours : ");
            Console.Write("      ");
            string Cours = Console.ReadLine() ?? "";
            Console.Write("                   ");
            Console.Write("Saisissez la Note : ");
            Console.Write("      ");
            string Note = Console.ReadLine() ?? "";
            Console.Write("                   ");
            Console.Write("Saisissez l'appreciation' : ");
            Console.Write("      ");
            string Appreciation = Console.ReadLine() ?? "";
            Console.Write("    ");


            int identifiantCours = 0;
            Dictionary<int, Dictionary<string, string>> ListeDeNote = new Dictionary<int, Dictionary<string, string>>();
            ListeDeNote[identifiantCours] = new Dictionary<string, string>
                                           {
                                                 { "Nom", Cours },
                                                 { "Note", Note },
                                                 { "Appréciation", Appreciation }
                                           };

            Eleves NewEleve = new Eleves();
            NewEleve.AjouterEleve(NomEleveSet, PreNomEleveSet, DateDeNaissanceEleveSet, ListeDeNote);
            NewEleve._EleveEnregistrerDonneesJson();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("    ");
            Console.Write("    ");
            Console.WriteLine($"Les données de l'élève ont été ajoutées et enregistrées avec succès.");
            Console.ResetColor();
            Console.Read();

            MainStudentMenu retourMenuPrincipal = new MainStudentMenu();
            retourMenuPrincipal._MenuPrincipalEtudiant();

        }  
    }
}
