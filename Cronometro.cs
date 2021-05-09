using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Cronometro
    {
        private DateTime inicioCronometro;
        public bool CronometroAndando { get; set; }
        public void IniciarCronometro()
        {
            inicioCronometro = DateTime.Now;
            CronometroAndando = true;
        }
        public TimeSpan PararCronometro()
        {
            DateTime finalCronometro = DateTime.Now;
            CronometroAndando = false;
            return finalCronometro - inicioCronometro;
        }
    }
}
