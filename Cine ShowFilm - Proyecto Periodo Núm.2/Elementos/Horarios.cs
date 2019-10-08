using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_ShowFilm___Proyecto_Periodo_Núm._2.Elementos
{
    public class Horarios : MainApp
    {
        string[] butaca;
        int cantidad;
        string temporal;
        string asiento;
        bool existencia, disponible = false;
        int opcionComprar;
        public int hora1;
        int entradasAdultos, entradasAdultoMayor, entradasNiños, totalEntradas;
        string asientoElegido;

        public void ElBromas_1()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos1();

        }
        public void ElBromas_2()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos2();

        }
        public void ElBromas_3()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos3();

        }
        public void IT1()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos4();

        }
        public void IT2()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos5();

        }
        public void IT3()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos6();

        }
        public void Family_1()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos7();

        }
        public void Family_2()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos8();

        }
        public void Family_3()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos9();

        }
        public void Camino_1()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos10();

        }
        public void Camino_2()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos11();

        }
        public void Camino_3()
        {
            Console.Clear();
            Console.WriteLine("EL BROMAS Y LA SOCIEDAD" +
                "\n\n[HORA: 10:15]" +
                "     \n        [SALA: 1]");
            MostrarSala();
            PedirAsientos12();

        }
        public void PedirAsientos1()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    
                    if (ventasHora1.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora1.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }

        public void PedirAsientos2()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    
                    if (ventasHora2.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora2.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora2)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }

        public void PedirAsientos3()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    
                    if (ventasHora3.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora3.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos4()
        {

            do
            {
                Console.Write("\nIngrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    
                    if (ventasHora4.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora4.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos5()
        {

            do
            {
                Console.Write("\nIngrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    
                    if (ventasHora5.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora5.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos6()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    
                    if (ventasHora6.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora6.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos7()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                   
                    if (ventasHora7.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora7.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos8()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                   
                    if (ventasHora8.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora8.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos9()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    Existencia();
                    if (ventasHora9.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora9.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos10()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    Existencia();
                    if (ventasHora10.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora10.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos11()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                   
                    if (ventasHora11.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora11.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void PedirAsientos12()
        {

            do
            {
                Console.WriteLine("Ingrese la cantidad de asientos:");
                ValidarCantidad();
                butaca = new string[cantidad];

                for (int i = 0; i < butaca.Length; i++)
                {
                Asiento:
                    Console.WriteLine("Ingrese el valor de la butaca N°{0}", i + 1);
                    temporal = Console.ReadLine();
                    Existencia();
                    if (ventasHora12.Contains(temporal))
                    {

                        Console.WriteLine("EL ASIENTO YA ESTA VENDIDO");
                        goto Asiento;
                    }
                    else
                        butaca[i] = temporal;
                }

                for (int i = 0; i < butaca.Length; i++)
                {
                    ventasHora12.Add(butaca[i]);
                }

                foreach (string asiento in ventasHora1)
                {
                    Console.Write(asiento + "\t");
                }

                Console.WriteLine("\n\n¿Desea comprar más asientos?" +
                    "\n 1) SI" +
                    "\n 2) NO");
                Console.Write("Opcion: ");
                ValidarQuererMas();

                Console.Clear();
            } while (opcionComprar != 2);
        }
        public void Existencia()
        {

            for (int i = 0; i < Letras.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (temporal.Equals(Asiento[i, j]))
                    {
                        existencia = true;
                        disponible = false;

                    }
                    
            }
            
            }
            if (existencia == false)
            {
                Console.WriteLine("\n La butaca elegida NO existe");
            }

        }

        public void ValidarCantidad()
        {
            if (int.TryParse(Console.ReadLine(), out cantidad))
            {


            }

            else
            {

                Console.WriteLine("DATO INVALIDO");
            }


        }
        public void ValidarQuererMas()
        {
            if (int.TryParse(Console.ReadLine(), out opcionComprar))
            {


            }

            else
            {

                Console.WriteLine("DATO INVALIDO");
            }


        }

        public double Total_Adultos(int entradas)
        {
            double subtotal;
            subtotal = entradas * 4.25;
            return subtotal;
        }
        public double Total_AdultosMayores(int entradas)
        {
            double subtotal;
            subtotal = entradas * 3.25;
            return subtotal;
        }
        public double Total_Niños(int entradas)
        {
            double subtotal;
            subtotal = entradas * 2.25;
            return subtotal;
        }

        public double Total_funciones()
        {
            double Total;
            Total = Total_Adultos(entradasAdultos) + Total_AdultosMayores(entradasAdultoMayor) + Total_Niños(entradasNiños);
            return Total;
        }

        public void MostrarSala()
        {
            Console.WriteLine("     |------------------------------------------|");
            Console.WriteLine("     |                                          |");
            Console.WriteLine("     |__________________________________________|");
            Console.WriteLine();
            Console.WriteLine("[A1] [A2] [A3] [A4] [A5] [A6] [A7] [A8] [A9] [A10]");
            Console.WriteLine("[B1] [B2] [B3] [B4] [B5] [B6] [B7] [B8] [B9] [B10]");
            Console.WriteLine("[C1] [C2] [C3] [C4] [C5] [C6] [C7] [C8] [C9] [C10]");
            Console.WriteLine("[D1] [D2] [D3] [D4] [D5] [D6] [D7] [D8] [D9] [D10]");
            Console.WriteLine("[E1] [E2] [E3] [E4] [E5] [E6] [E7] [E8] [E9] [E10]");
            Console.WriteLine("[F1] [F2] [F3] [F4] [F5] [F6] [F7] [F8] [F9] [F10]");
            Console.WriteLine("[G1] [G2] [G3] [G4] [G5] [G6] [G7] [G8] [G9] [G10]");
            Console.WriteLine("[H1] [H2] [H3] [H4] [H5] [H6] [H7] [H8] [H9] [H10]");
            Console.WriteLine("[I1] [I2] [I3] [I4] [I5] [I6] [I7] [I8] [I9] [I0]");
            Console.WriteLine("[J1] [J2] [J3] [J4] [J5] [J6] [J7] [J8] [J9] [J10]");
           

        }
    }
}
