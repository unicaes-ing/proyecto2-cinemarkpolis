using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_ShowFilm___Proyecto_Periodo_Núm._2
{
    public class MainApp
    {
       
        static void Main(string[] args)
        {
            var Menu = new Elementos.Menús();
            var Cartelera = new Elementos.Carteleras();
            var Horarios = new Elementos.Horarios();
            var Estadistica = new Elementos.Estadistica();
            var conf = new Elementos.Configuración();
            bool menuP = false;
            do
            {
                Menu.MenuPrincipal();
                Menu.ValidarMenuPrincipal();
                //Menus
                switch (Menu.opcionMenuprincipal)
                {
                    case 1:
                        Menu.MenuVentaBoletos();
                        Menu.ValidarMenuVentaBoletos();
                        //Entrar a Catelera y Peliculas
                        switch (Menu.opcionVentaBoletos)
                        { 
                            //Entrar a una pelicula
                            case 1:
                                Cartelera.Pelicula_1();
                                Cartelera.ValidarOpcionPelicula1();
                                //HORARIOS EL BROMAS.
                                switch (Cartelera.opcionPelicula1)
                                {
                                    case 1:
                                        Horarios.ElBromas_1();
                                        break;
                                    case 2:
                                        Horarios.ElBromas_2();
                                        break;
                                    case 3:
                                        Horarios.ElBromas_3();
                                        break;
                                    case 9:
                                        Menu.MenuVentaBoletos();
                                        Menu.ValidarMenuVentaBoletos();
                                        break;
                                }
                                break;
                            case 2:
                                Cartelera.Pelicula_2();
                                Cartelera.ValidarOpcionPelicula2();
                                switch (Cartelera.opcionPelicula2)
                                {
                                    case 1:
                                        Horarios.IT1();
                                        break;
                                    case 2:
                                        Horarios.IT2();
                                        break;
                                    case 3:
                                        Horarios.IT3(); 
                                        break;
                                    case 9:
                                        Menu.MenuVentaBoletos();
                                        Menu.ValidarMenuVentaBoletos();
                                        break;
                                }
                                break;
                            case 3:
                                Cartelera.Pelicula_3();
                                Cartelera.ValidarOpcionPelicula3();
                                switch (Cartelera.opcionPelicula3)
                                {
                                    case 1:
                                        Horarios.Family_1();
                                        break;
                                    case 2:
                                        Horarios.Family_2();
                                        break;
                                    case 3:
                                        Horarios.Family_3();
                                        break;
                                    case 9:
                                        Menu.MenuVentaBoletos();
                                        Menu.ValidarMenuVentaBoletos();
                                        break;
                                }
                                break;
                            case 4:
                                Cartelera.Pelicula_4();
                                Cartelera.ValidarOpcionPelicula4();
                                switch (Cartelera.opcionPelicula4)
                                {
                                    case 1:
                                        Horarios.Camino_1();
                                        break;
                                    case 2:
                                        Horarios.Camino_2();
                                        break;
                                    case 3:
                                        Horarios.Camino_3();
                                        break;
                                    case 9:
                                        Menu.MenuVentaBoletos();
                                        Menu.ValidarMenuVentaBoletos();
                                        break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        Menu.MenuEstadisticas();
                        Menu.ValidarEstadisticas();
                        switch (Menu.opcionEstadisticas)
                        {
                            case 1:
                                Estadistica.BoletosPorFuncion();
                                Estadistica.ValidarBoletosPorFuncion();
                                switch (Estadistica.opcionNumFuncion)
                                {
                                    case 1:
                                        Estadistica.MostrarVentas1();
                                        break;

                                    case 2:
                                        Estadistica.MostrarVentas2();
                                        break;

                                    case 3:
                                        Estadistica.MostrarVentas3();
                                        break;

                                    case 4:
                                        Estadistica.MostrarVentas4();
                                        break;

                                    case 5:
                                        Estadistica.MostrarVentas5();
                                        break;

                                    case 6:
                                        Estadistica.MostrarVentas6();
                                        break;

                                    case 7:
                                        Estadistica.MostrarVentas7();
                                        break;

                                    case 8:
                                        Estadistica.MostrarVentas8();
                                        break;

                                    case 9:
                                        Estadistica.MostrarVentas9();
                                        break;
                                    case 10:
                                        Estadistica.MostrarVentas10();

                                        break;
                                    case 11:
                                        Estadistica.MostrarVentas11();
                                        break;
                                    case 12:
                                        Estadistica.MostrarVentas12();

                                        break;
                                }
                           

                                break;
                            case 2:
                                Horarios.Total_funciones();
                                Console.ReadKey();
                                break;

                        }

                        break;
                    case 3:
                        Menu.MenuConfiguracion();
                        Menu.ValidarConfiguraciones();
                        switch (Menu.opcionConfiguraciones)
                        {

                            case 1:
                                conf.ReiniciarTodo();
                                break;
                            case 2:
                                conf.seleccionarQueReiniciar();
                                conf.ValidarQueReiniciar();
                                switch (conf.seleccionReinicio)
                                {
                                    case 1:
                                        conf.ReinciarHora1();
                                        break;
                                    case 2:
                                        conf.ReinciarHora2();
                                        break;
                                    case 3:
                                        conf.ReinciarHora3();
                                        break;
                                    case 4:
                                        conf.ReinciarHora4();
                                        break;
                                    case 5:
                                        conf.ReinciarHora5();
                                        break;
                                    case 6:
                                        conf.ReinciarHora6();
                                        break;
                                    case 7:
                                        conf.ReinciarHora7();
                                        break;
                                    case 8:
                                        conf.ReinciarHora8();
                                        break;
                                    case 9:
                                        conf.ReinciarHora9();
                                        break;
                                    case 10:
                                        conf.ReinciarHora10();
                                        break;
                                    case 11:
                                        conf.ReinciarHora11();
                                        break;
                                    case 12:
                                        conf.ReinciarHora12();
                                        break;
                                 
                                }
                                break;



                        }
                        break;
                    case 4:
                        Menu.SalirPrograma();
                        break; 
                }



            } while (menuP == false);


        }

        //Listas: NO SE DEBEN TOCAR.
        public List<string> ventasHora1 = new List<string>();
        public List<string> ventasHora2 = new List<string>();
        public List<string> ventasHora3 = new List<string>();
        public List<string> ventasHora4 = new List<string>();
        public List<string> ventasHora5 = new List<string>();
        public List<string> ventasHora6 = new List<string>();
        public List<string> ventasHora7 = new List<string>();
        public List<string> ventasHora8 = new List<string>();
        public List<string> ventasHora9 = new List<string>();
        public List<string> ventasHora10 = new List<string>();
        public List<string> ventasHora11 = new List<string>();
        public List<string> ventasHora12 = new List<string>();



        //Validaciones, y vale berga
        public static string[] Letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public static int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static string[,] Asiento = new string[10, 10];

    }
}
