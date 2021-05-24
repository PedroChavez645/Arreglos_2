using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_2
{
    class Program
    {

        //La empresa apple cuenta con 2 turnos (matutino y vespertino)
        //La plantilla es de 10 empleados (5 en el turno matutino y 5 en el turno vespertino)
        //Desarrollar un programa que almacene los sueldos de los emppleados por turno
        //Vector unidimensional de tipo float

       
        private int[] sueldosM;
        private int[] sueldosV;

        public void CargarSalariosM()
        {

            //Iniciar vector en 5 matutino
            sueldosM = new int[6];
            Console.WriteLine("SUELDOS DE TRABAJADORES MATUTINOS");
            for (int i = 1; i <= 5; i++)
            {
                
                Console.WriteLine("Ingrese el sueldo del trabajador " + i + ": ");
                string lineacaptura = Console.ReadLine();
                sueldosM[i] = int.Parse(lineacaptura); //Asignamos sueldos al vector
            }

        }

        public void imprimirM()
        {
            Console.WriteLine("Los sueldos de los trabajadores matutinos son");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("[" + sueldosM[i] + "]");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }


        public void CargarSalariosV()
        {

            //Iniciar vector en 5 vespertino
            sueldosV = new int[6];
            Console.WriteLine("SUELDOS DE TRABAJADORES VESPERTINOS");
            for (int i = 1; i <= 5; i++)
            {
                
                Console.WriteLine("Ingrese el sueldo del trabajador " + i + ": ");
                string lineacaptura = Console.ReadLine();
                sueldosV[i] = int.Parse(lineacaptura); //Asignamos sueldos al vector
            }

        }

        public void imprimirV()
        {
            Console.WriteLine("Los sueldos de los trabajadores vespertinos son");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("[" + sueldosV[i] + "]");
            }
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }

        private void CalcularGastos()
        {
            float gastosM = 0;
            float gastosV = 0;

            for (int i = 0; i < 4; i++)
            {
                gastosM = gastosM + sueldosM[i];
            }

            for (int i = 0; i < 4; i++)
            {
                gastosV = gastosV + sueldosV[i];
            }

            Console.WriteLine("Total de gastos del turno matutino: " + gastosM);
            Console.WriteLine("Total de gastos del turno vespertino: " + gastosV);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program sueldos = new Program();
            sueldos.CargarSalariosM();
            sueldos.imprimirM();
            sueldos.CargarSalariosV();
            sueldos.imprimirV();
            sueldos.CalcularGastos();
        }
    }
}
