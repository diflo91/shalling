using Application_wild_student.Eleve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Etudiant
{
    public class StudentMenu : MenuAttribute
    {
        public void _StudentMenuChoice()
        {
            while (true)
            {
                MainStudentMenu MenuPrincipalEtudiant = new MainStudentMenu();

                isValideMenu = int.TryParse(MenuPrincipalEtudiant._MenuPrincipalEtudiant(), out ChoixOptionInt);
                if (isValideMenu)
                {
                    if (ChoixOptionInt == 5)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (ChoixOptionInt == 1)
                    {
                        ListStudent listerEleve = new ListStudent();
                        listerEleve._ListerEleve();
                    }
                    else if (ChoixOptionInt == 2)
                    {
                       CreateStudant creerEleve = new CreateStudant();  
                        creerEleve._CreerEleve();
                    }
                    else if (ChoixOptionInt == 3)
                    {
                        ConsultStudant consulterEleve = new ConsultStudant();
                        consulterEleve._ConsulterEleve();
                    }
                    else if (ChoixOptionInt == 4)
                    {
                        AddNote ajouterNote = new AddNote();
                        ajouterNote._AjouterNote();
                    }
                    else
                    {
                        ErrorChoiceSelection erreurDeselection = new ErrorChoiceSelection();
                        erreurDeselection._ErreurDeSelection();
                    }
                }
                else
                {
                    ErrorChoiceSelection erreurNumeroSeulement = new ErrorChoiceSelection();
                    erreurNumeroSeulement._ErrorNumberOnly();


                }
            }
        }

    }
}
