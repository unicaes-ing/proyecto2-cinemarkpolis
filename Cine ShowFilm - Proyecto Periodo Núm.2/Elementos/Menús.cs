using System;


namespace Cine_ShowFilm___Proyecto_Periodo_Núm._2.Elementos
{
    public class Menús
    {
        public int opcionMenuprincipal, opcionVentaBoletos, opcionEstadisticas, opcionConfiguraciones;
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ____  ____  ____  ____  _________  ____  ____  ____  ____  ____  ____  ____  ____ " +
                "            \n||C ||||i ||||n ||||e ||||       ||||S ||||h ||||o ||||w ||||F ||||i ||||l ||||m ||"
                + "          \n||__||||__||||__||||__||||_______||||__||||__||||__||||__||||__||||__||||__||||__||"
                + "          \n||__||||__||||__||||__||||_______||||__||||__||||__||||__||||__||||__||||__||||__||");

            Console.WriteLine("\n|1| Venta de Boletos"
                + "\n|2| Estadisticas" +
                "\n|3| Configuración" +
                "\n|4| Salir");

            Console.Write("\n|Su Opción|: ");
            Console.ForegroundColor = ConsoleColor.Red;





        }
        //SubMenus:

        public void MenuVentaBoletos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|   _____                  _            _                        |" +
                "\n|  / ____|                | |          | |                       |" +
                "\n| | |        __ _   _ __  | |_    ___  | |   ___   _ __    __ _  |" +
                "\n| | |       / _` | | '__| | __|  / _   | |  / _   | '__|  / _` | |" +
                "\n| | |____  | (_| | | |    | |_  |  __/ | | |  __/ | |    | (_| | |" +
                "\n|  /_____|  /__,_| |_|     /__|  /___| |_|  /___| |_|     /__,_| |" +
                "\n|________________________________________________________________|");
            Console.WriteLine("\n [----Estreno Exclusivo-----]\n" +
                "\n    1) El bromas y la sociedad.\n" +
                "\n [----Tambien podría gustarte-----]\n" +
                "\n    2) IT: Chapter 2\n" +
                "\n    3) The Family\n" +
                "\n    4) El Camino\n" +
                "\n\n 9) Regresar al menú principal.");
            Console.Write("Opcion a escoger: ");
            Console.ForegroundColor = ConsoleColor.Red;

        }

        public void MenuEstadisticas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ________            __                    __ __            __     __    " +
                "\n/        |          /  |                  /  /  |          /  |   /  |               " +
                "\n$$$$$$$$/  _______ _$$ |_    ______   ____$$ $$/  _______ _$$ |_  $$/  _______  ______   _______" +
                "\n$$ |__    /       / $$   |  /        /    $$ /  |/       / $$   | /  |/       |/        /       |" +
                "\n$$    |  /$$$$$$$/$$$$$$/   $$$$$$  /$$$$$$$ $$ /$$$$$$$/$$$$$$/  $$ /$$$$$$$/ $$$$$$  /$$$$$$$/ " +
                "\n$$$$$/   $$         $$ | __ /    $$ $$ |  $$ $$ $$         $$ | __$$ $$ |      /    $$ $$        " +
                "\n$$ |_____ $$$$$$  | $$ |/  /$$$$$$$ $$  __$$ $$ |$$$$$$  | $$ |/  $$ $$  _____/$$$$$$$ |$$$$$$  |" +
                "\n$$       /     $$/  $$  $$/$$    $$ $$    $$ $$ /     $$/  $$  $$/$$ $$       $$    $$ /     $$/ " +
                "\n$$$$$$$$/$$$$$$$/    $$$$/  $$$$$$$/ $$$$$$$/$$/$$$$$$$/    $$$$/ $$/ $$$$$$$/ $$$$$$$/$$$$$$$/  " +
                "\n \n[----CONOCE ACERCA DE-----]\n" +
                "\n    1) Cantidad de boletos vendidos por función\n" +
                "\n    2) Total de ingresos por función\n" +
                "\n    3) Total de ingresos globales.\n" +
                "\n\n 9) Regresar al menu principal.");
            Console.Write("Su opción: ");

        }

        public void MenuConfiguracion()
        {
            Console.Clear();
            Console.WriteLine("   _____             __ _                            _               " +
                "\n / ____|            / _(_)                          (_)                     " +
                "\n | |     ___  _ __ | |_ _  __ _ _   _ _ __ __ _  ___ _  ___  _ __   ___  ___ " +
                "\n | |    / _  | '_  |  _| |/ _` | | | | '__/ _` |/ __| |/ _  | '_   / _  / __|" +
                "\n | |___| (_) | | | | | | | (_| | |_| | | | (_| | (__| | (_) | | | |  __/ __  " +
                "\n  _____  ___/|_| |_|_| |_| __, | __,_|_|   __,_| ___|_| ___/|_| |_| ___||___/" +
                "\n                           __/ |                                " +
                "\n                          |___/        " +
                "\n\n" +
                "\n 1) REINICIAR TODAS LAS FUNCIONES" +
                "\n 2) REINICIAR FUNCIÓN EN ESPECIFICO." +
                "\n\n     9) Regresar al menu principal");
            Console.Write("\n Opción a elegir: ");
        }


        public void DatoInvalido()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alerta: Dato Ingresado Invalido");
            Console.ReadKey();
        }

        public void OpcionMenuInvalida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alerta: Opción ingresada Invalida");
            Console.ReadKey();


        }
        public void ValidarMenuPrincipal()
        {
            if (int.TryParse(Console.ReadLine(), out opcionMenuprincipal))
            {


            }
            else
            {
                DatoInvalido();

            }

        }

        public void ValidarMenuVentaBoletos()
        {
            if (int.TryParse(Console.ReadLine(), out opcionVentaBoletos))
            {


            }

            else
            {

                DatoInvalido();
            }

        }

        public void ValidarEstadisticas()
        {
            if (int.TryParse(Console.ReadLine(), out opcionEstadisticas))
            {


            }
            else
            {
                DatoInvalido();

            }

        }

        public void ValidarConfiguraciones()
        {

            if (int.TryParse(Console.ReadLine(), out opcionConfiguraciones))
            {


            }
            else
            {
                DatoInvalido();

            }

        }

        public void SalirPrograma()
        {

            Environment.Exit(1);
        }

    }
}
