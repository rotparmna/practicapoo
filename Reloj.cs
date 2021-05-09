using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Reloj
    {
        public Reloj()
        {
            MiCronometro = new Cronometro();
        }
        private int Tamaño { get; set; }
        private string Tipo { get; set; }
        public TimeSpan Tiempo { get; set; }
        public Cronometro MiCronometro { get; set; }
        public void CalcularTiempo(string pila)
        {

        }
    }
}
