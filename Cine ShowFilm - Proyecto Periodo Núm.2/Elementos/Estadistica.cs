using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_ShowFilm___Proyecto_Periodo_Núm._2.Elementos
{
    public class Estadistica
    {
        public int opcionNumFuncion, seleccionReinicio;
        public void BoletosPorFuncion()
        {

            Console.Clear();
            Console.WriteLine("[BOLETOS POR FUNCIÓN]" +
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
        public void ValidarBoletosPorFuncion()
        {

            if (int.TryParse(Console.ReadLine(), out opcionNumFuncion))
            {


            }
            else
            {

            }

        }
        public void MostrarVentas1()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }

        public void MostrarVentas2()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas3()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas4()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas5()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas6()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas7()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas8()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas9()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas10()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas11()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
        public void MostrarVentas12()
        {
            var horario = new Horarios();
            Console.WriteLine("Total Ventas: {0}", horario.hora1);
            Console.Read();
        }
    }

}
