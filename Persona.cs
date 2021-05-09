using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Persona
    {
        public Persona()
        {
            MiReloj = new Reloj();
        }
        public Reloj MiReloj { get; set; }
        public void PincharCronometro()
        {
            if (MiReloj.MiCronometro.CronometroAndando==false)
            {
                MiReloj.MiCronometro.IniciarCronometro();
            }
            else
            {
                TimeSpan time = MiReloj.MiCronometro.PararCronometro();
                Console.WriteLine("El tiempo del cronometro es: {0:dd\\.hh\\:mm\\:ss}", time);
            }
        }
        public void MirarHora()
        {

        }
    }
}
