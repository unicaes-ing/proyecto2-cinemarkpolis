using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_ShowFilm___Proyecto_Periodo_Núm._2.Elementos
{
    public class Carteleras
    {
        public int opcionPelicula1, opcionPelicula2, opcionPelicula3, opcionPelicula4;

        public void Pelicula_1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_____ _  ______                                         _         _____            _          _            _" +
                "\n|  ___| | | ___ /                                       | |       /  ___|          (_)        | |         ||" +
                "\n| |__ | | | |_/ /_ __ ___  _ __ ___   __ _ ___   _   _  | | __ _ / `--.  ___   ___ _  ___  __| | __ _  __| |" +
                "\n|  __|| | | ___ / '__/ _ )| '_ ` _ / / _` / __| | | | | | |/ _` | `--. // _  / __| |/ _ // _` |/ _` |/ _`  | " +
                "\n| |___| | | |_/ / | | (_) | | | | | | (_| __ /  | |_| | | | (_|  //__/ / (_) |( (__| |  __/ (_| | (_| | (_| |" +
                "\n(____/|_| (____/|_|  /___/|_| |_| |_|__,_|___/  __, | |_| /__,_| /____/ ____/ (___|_|  ___| __,_| __,_|__,_|" +
                "\n                                                  __/ |                                                      " +
                "\n                                                 |___/                                                       " +
                "\n\n [HORARIOS: SALA 1]" +
                "\n \n   1)10:15 A.M     2)2:30 P.M    3)8:30 P.M.  " +
                "\n\n 9) Regresar a Cartelera.");
            Console.Write("\nEscoger Horario: ");

        }
        public void Pelicula_2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" ██▓▄▄▄█████▓    ▄████▄   ██░ ██  ▄▄▄       ██▓███  ▄▄▄█████▓▓█████  ██▀███     ▄▄▄█████▓ █     █░ ▒█████ " +
                "\n▓██▒▓  ██▒ ▓▒   ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒   ▓  ██▒ ▓▒▓█░ █ ░█░▒██▒  ██▒" +
                "\n▒██▒▒ ▓██░ ▒░   ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒   ▒ ▓██░ ▒░▒█░ █ ░█ ▒██░  ██▒" +
                "\n░██░░ ▓██▓ ░    ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄     ░ ▓██▓ ░ ░█░ █ ░█ ▒██   ██░" +
                "\n░██░  ▒██▒ ░    ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒     ▒██▒ ░ ░░██▒██▓ ░ ████▓▒░" +
                "\n░▓    ▒ ░░      ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░     ▒ ░░   ░ ▓░▒ ▒  ░ ▒░▒░▒░" +
                "\n ▒ ░    ░         ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░       ░      ▒ ░ ░    ░ ▒ ▒░" +
                "\n ▒ ░  ░         ░         ░  ░░ ░  ░   ▒   ░░         ░         ░     ░░   ░      ░        ░   ░  ░ ░ ░ ▒ " +
                "\n\n [HORARIOS: SALA 2]" +
                "\n \n   1)12:20 P.M     2)4:50 P.M    3)11:30 P.M.  "
                +
                "\n\n 9) Regresar a Cartelera.");
            Console.Write("\nEscoger Horario: ");

        }
        public void Pelicula_3()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" _______   _             ______                       _   _       " +
                "\n|__   __| | |           |  ____|                     (_) | |       " +
                "\n  | |    | |__     ___  | |__      __ _   _ __ ___    _  | |  _   _" +
                "\n  | |    | '_     / _   |  __|    / _` | | '_ ` _    | | | | | | | |" +
                "\n  | |    | | | | |  __/ | |      | (_| | | | | | | | | | | | | |_| |" +
                "\n  |_|    |_| |_|  ___   |_|       /__,_| |_| |_| |_| |_| |_|   __, |" +
                "\n                                                               __/ |" +
                "\n                                                              |___/ " +
                "\n\n [HORARIOS: SALA 3]" +
                "\n \n   1)9:55 A.M     2)1:40 P.M    3)7:00 P.M.  "
                +
                "\n\n 9) Regresar a Cartelera.");
            Console.Write("\nEscoger Horario: ");

        }

        public void Pelicula_4()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ________  __               ______                           __                     " +
                "\n/        |/  |             /      /                         /  |                    " +
                "\n$$$$$$$$/ $$ |            /$$$$$$  |  ______   _____  ____  $$/  _______    ____" +
                "\n$$ |__    $$ |            $$ |  $$/  /        /      /      /  |/          /        " +
                "\n$$    |   $$ |            $$ |       $$$$$$  |$$$$$$ $$$$  |$$ |$$$$$$$  |/$$$$$$  |" +
                "\n$$$$$/    $$ |            $$ |   __  /    $$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$ |  $$ |" +
                "\n$$ |_____ $$ |_____       $$  __/  |/$$$$$$$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$  __$$ |" +
                "\n$$       |$$       |      $$    $$/ $$    $$ |$$ | $$ | $$ |$$ |$$ |  $$ |$$    $$/" +
                "\n$$$$$$$$/ $$$$$$$$/        $$$$$$/   $$$$$$$/ $$/  $$/  $$/ $$/ $$/   $$/  $$$$$$/ " +
                "\n\n [HORARIOS: SALA 4]" +
                "\n \n   1)12:05 P.M     2)6:20 P.M    3)10:05 P.M.  "
                +
                "\n\n 9) Regresar a Cartelera.");
            Console.Write("\nEscoger Horario: ");

        }

        public void ValidarOpcionPelicula1()
        {
            if (int.TryParse(Console.ReadLine(), out opcionPelicula1))
            {


            }
            else
            {


            }

        }
        public void ValidarOpcionPelicula2()
        {
            if (int.TryParse(Console.ReadLine(), out opcionPelicula2))
            {


            }
            else
            {


            }

        }
        public void ValidarOpcionPelicula3()
        {
            if (int.TryParse(Console.ReadLine(), out opcionPelicula3))
            {


            }
            else
            {


            }

        }
        public void ValidarOpcionPelicula4()
        {
            if (int.TryParse(Console.ReadLine(), out opcionPelicula4))
            {


            }
            else
            {


            }

        }
    }
}
