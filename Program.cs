using System;

namespace TrabajoFinalProcesos
{
    class Program
    {
        static void Main()
        {
            //Simulacion 
            Console.WriteLine("Simulacion \n");

            //Variables necesarias
            int dado;
            Random random = new Random();
            int cantidadTiros;
            float total = 0;

            //variable inicial (tiros)
            Console.WriteLine("ingrese la cantidad de tiros:");
            cantidadTiros = int.Parse(Console.ReadLine());

            //Casillas: de "1" a "4" y de "A" a "D" respectivamente
            int casillaActual;

            //Inicio
            casillaActual = 1;

            for (int i = 0; i < cantidadTiros; i++)
            {
            //Juego    
                
                dado = random.Next(1, 7);
                Console.WriteLine("\ndado = " + dado);

                //Movimiento 
                if (casillaActual + dado >= 4)
                {
                    if ((casillaActual + dado) % 4 == 0)
                    {
                        casillaActual = 4;
                    }
                    else
                        casillaActual = (casillaActual + dado) % 4;
                }
                else
                    casillaActual = casillaActual + dado;
                            
            //Ganancias     

                switch (casillaActual)
                {
                    case 1:
                        total += 4.20f;
                        Console.WriteLine("A = $4.2");
                        break;
                    case 2:
                        total += 2.20f;
                        Console.WriteLine("B = $2.2");
                        break;
                    case 3:
                        total += 9f;
                        Console.WriteLine("C = $9");
                        break;
                    case 4:
                        total += 6f;
                        Console.WriteLine("D = $6");
                        break;
                }
            }

            //Total 
            Console.WriteLine("\n\nTotal = $" + total);

            ////////////////////////////////////////////////////////////////////////

            /*
            //Probabilidad 
            Console.WriteLine("\n\n Probabilidad \n");

            float[,] transicion = new float[4, 4];

            //fila 1
            transicion[0, 0] = 0.166f;
            transicion[0, 1] = 0.333f;
            transicion[0, 2] = 0.333f;
            transicion[0, 3] = 0.166f;
            //fila 2
            transicion[1, 0] = 0.166f;
            transicion[1, 1] = 0.166f;
            transicion[1, 2] = 0.333f;
            transicion[1, 3] = 0.333f;
            //fila 3
            transicion[2, 0] = 0.333f;
            transicion[2, 1] = 0.166f;
            transicion[2, 2] = 0.166f;
            transicion[2, 3] = 0.333f;
            //fila 4
            transicion[3, 0] = 0.333f;
            transicion[3, 1] = 0.333f;
            transicion[3, 2] = 0.166f;
            transicion[3, 3] = 0.166f;

            Console.WriteLine(transicion[0, 0] + " " + transicion[0, 1] + " " + transicion[0, 2] + " " + transicion[0, 3] + " ");
            Console.WriteLine(transicion[1, 0] + " " + transicion[1, 1] + " " + transicion[1, 2] + " " + transicion[1, 3] + " ");
            Console.WriteLine(transicion[2, 0] + " " + transicion[2, 1] + " " + transicion[2, 2] + " " + transicion[2, 3] + " ");
            Console.WriteLine(transicion[3, 0] + " " + transicion[3, 1] + " " + transicion[3, 2] + " " + transicion[3, 3] + " \n\n");

            float[,] probIniciales = new float[1, 4];

            //fila 1
            probIniciales[0, 0] = 0.166f;
            probIniciales[0, 1] = 0.333f;
            probIniciales[0, 2] = 0.333f;
            probIniciales[0, 3] = 0.166f;


            float[,] retribucion = new float[1, 4];

            //fila 1
            retribucion[0, 0] = 4.2f;
            retribucion[0, 1] = 2.2f;
            retribucion[0, 2] = 6f;
            retribucion[0, 3] = 9f;

            float[,] transicionN;
            float[,] transicionTemp;
            float[,] probNLanzamientos;

            //transicion a la n
            transicionTemp = new float[transicion.GetLength(0), transicion.GetLength(1)];
            transicionTemp = transicion;

            for (int i = 0; i < cantidadTiros; i++)//n veces
            {
                //transicionTemp * transicionTemp
                for (int j = 0; j < transicion.GetLength(1)/*columnas matriz b; j++)
                {
                    for (int q = 0; q < transicionTemp.GetLength(0)/*filas matriz a; q++)
                    {
                        float sum = 0;
                        for (int k = 0; k < transicionTemp.GetLength(1)/*columna matriz a; k++)
                        {
                            sum = transicionTemp[q, k] * transicion[q, k];
                        }
                        transicionTemp[q, j] = sum;
                    }
                }
            }

            Console.WriteLine(transicionTemp[0, 0] + " " + transicionTemp[0, 1] + " " + transicionTemp[0, 2] + " " + transicionTemp[0, 3] + " ");
            Console.WriteLine(transicionTemp[1, 0] + " " + transicionTemp[1, 1] + " " + transicionTemp[1, 2] + " " + transicionTemp[1, 3] + " ");
            Console.WriteLine(transicionTemp[2, 0] + " " + transicionTemp[2, 1] + " " + transicionTemp[2, 2] + " " + transicionTemp[2, 3] + " ");
            Console.WriteLine(transicionTemp[3, 0] + " " + transicionTemp[3, 1] + " " + transicionTemp[3, 2] + " " + transicionTemp[3, 3] + " ");
            */
        }
    }
}
