using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas30
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            Console.ReadKey();
            
            DateTime fecha = Validador.ValidarFechaIngresada("\n Ingrese una Fecha y hora si lo desea."+ 
                                                             "\n Si no ingresa la hora solo vera *0:00* como resultado final");
            
            Console.Clear();
            Console.WriteLine("\n De la fecha ingresada la hora es: " + fecha.ToLongTimeString());
            

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
