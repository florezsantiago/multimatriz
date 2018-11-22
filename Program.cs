using System;

namespace multima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el numero de estudiantes: ");
            Console.WriteLine("*************************************");

            int nestudiante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese el nombre de los estudiantes: ");
            Console.WriteLine("*************************************");
            string[] nombre = new string [nestudiante];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write($"Nombre Estudiante {i+1}: ");
                string nombress = Convert.ToString(Console.ReadLine());
                nombre[i] = nombress;
            }
            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese la cantidad de cortes por semestre: ");
            Console.WriteLine("*************************************");

            int cortes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************");
            Console.Write("Ingrese la cantidad de notas por corte: ");
            Console.WriteLine("*************************************");
            
            int notaza = Convert.ToInt32(Console.ReadLine());
            double [,] matriz = new double [nestudiante,cortes * notaza+1];
            double notasalon = 0;
            double sumasalon = 0;
            double salonprom = 0;

            Console.WriteLine($"escriba nota del estudiante: ");
            for (int i = 0; i<nestudiante ; i++)
            {
                notasalon = 0;
                for (int e = 0; e < cortes * notaza; e++)
                {
                    Console.Write($"Nota {e+1} del estudiante {nombre[i]}: ");
                    double llenar = Convert.ToDouble(Console.ReadLine());
                    matriz[i,e] = llenar;
                    notasalon = notasalon+llenar;
                    if (e == cortes * notaza-1)
                    {
                        matriz[i,e+1] = notasalon/cortes * notaza;
                        sumasalon = matriz[i,e+1] + sumasalon;
                    }
                }
            }

            Console.WriteLine("notas.");
            for (int i = 0; i<nestudiante ; i++)
            {
                for (int e = 0; e < cortes * notaza+1; e++)
                {
                    Console.Write($"{matriz[i,e]} ");
                }
                Console.WriteLine("");
            }

            salonprom = sumasalon/nestudiante;
            Console.WriteLine("*************************************");
            Console.WriteLine($"El promedio del curso es de: {salonprom}");
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");
            Console.WriteLine("Los estudiantes que pasaron son:");
            Console.WriteLine("*************************************");
            for (int i = 0; i < nestudiante; i++)
            {
                if (matriz[i,cortes * notaza] >= 3)
                {
                    Console.WriteLine($"{nombre[i]}");
                }
                
            }

            Console.WriteLine("*************************************");
            Console.WriteLine("Los estudiantes que perdieron son:");
            Console.WriteLine("*************************************");
            for (int i = 0; i < nestudiante; i++)
            {
                if (matriz[i,cortes * notaza] < 3)
                {
                    Console.Write($"{nombre[i]}");
                }
                Console.WriteLine("");
            }


            double maximo = 0;
            string mayor = "";

            for (int i = 0; i < nestudiante; i++)
            {
                if (matriz[i,cortes * notaza] > maximo)
                {
                    maximo = matriz[i,cortes * notaza];
                    mayor = nombre[i];
                }
            }
            Console.WriteLine("*************************************");
            Console.Write("El estudiante de mayor promedio en el curso es: ");
            Console.WriteLine($"{mayor}");
            Console.WriteLine("*************************************");


            
            double minimo = matriz[0,cortes * notaza];
            string menor = "";

            for (int i = 0; i < nestudiante; i++)
            {
                if (matriz[i,cortes * notaza] <= minimo)
                {
                    minimo = matriz[i,cortes * notaza];
                    menor = nombre[i];
                }
            }
            Console.WriteLine("*************************************");
            Console.Write("menor promedio en el curso es de: ");
            Console.WriteLine($"{menor}");
            Console.WriteLine("*************************************");


            Console.ReadLine();

    
            




            


            


        }
    }
}
