using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_ShowFilm___Proyecto_Periodo_Núm._2.Elementos
{
    public class Configuración : MainApp
    {
       public int seleccionReinicio;
        public void ReiniciarTodo()
        {

            Console.WriteLine("\nREINICIANDO TODAS LAS FUNCIONES...");
            Console.ReadKey();
            ventasHora1.Clear();
            ventasHora2.Clear();
            ventasHora3.Clear();
            ventasHora4.Clear();
            ventasHora5.Clear();
            ventasHora6.Clear();
            ventasHora7.Clear();
            ventasHora8.Clear();
            ventasHora9.Clear();
            ventasHora10.Clear();
            ventasHora11.Clear();
            ventasHora12.Clear();
            Console.Write("REINICIADO EXITOSO.");
            Console.ReadKey();
        }

        public void seleccionarQueReiniciar()
        {
            Console.Clear();
            Console.WriteLine("¿Que función Desea Reinciar?" +
               "\n   \n[EL BROMAS Y LA SOCIEDAD: SALA 1]" +
                "\n    1) PRIMER HORARIO" +
                "\n    2) SEGUNDO HORARIO" +
                "\n    3) TERCER HORARIO" +
                "\n\n [IT CHAPTER TWO: SALA 2]" +
                "\n    4) PRIMER HORARIO" +
                "\n    5) SEGUNDO HORARIO" +
                "\n    6) TERCER HORARIO" +
                "\n\n [THE FAMILY: SALA 3]" +
                "\n    7) PRIMER HORARIO" +
                "\n    8) SEGUNDO HORARIO" +
                "\n    9) TERCER HORARIO" +
                "\n\n [EL CAMINO: SALA 4]" +
                "\n    10) PRIMER HORARIO" +
                "\n    11) SEGUNDO HORARIO" +
                "\n    12) TERCER HORARIO");
            Console.Write("\nOpción a escoger: ");


        }
        public void ValidarQueReiniciar()
        {
            if (int.TryParse(Console.ReadLine(), out seleccionReinicio))
            {


            }
            else
            {


            }

        }
        public void ReinciarHora1()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora1.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora2()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora2.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora3()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora3.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora4()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora4.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora5()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora5.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora6()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora6.Clear();
            Console.ReadLine();

        }
        public void ReinciarHora7()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora7.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora8()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora8.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora9()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora9.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora10()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora10.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora11()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora11.Clear();
            Console.ReadLine();
        }
        public void ReinciarHora12()
        {

            Console.WriteLine("\nReiniciado la Función...");
            ventasHora12.Clear();
            Console.ReadLine();
        }
    }
}
