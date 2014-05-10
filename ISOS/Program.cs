using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOS
{
    static class Program
    {

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Engine main = new Engine();

            while (main.modulLogowania()) //Uruchamiam moduł logowania, jeżeli zalogowano to zwracam true
            {
                main.modulUzytkownika(); //Na podstawie parametrów konta, wyświetlam odpowiednie okno
            }
  
        }
    }
}
