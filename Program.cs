using System;

namespace TrabajoFinalProcesos
{
    class Program
    {
        static float[][] multiplyMatrix(float a[][], float b[][]) {
          int ar = a.length; // Matrix a rows
          int ac = a[0].length;  // Matrix a columns
          int br = b.length; // Matrix b rows
          int bc = b[0].length; // Matrix b columns
          
          float p[ar][bc] = new float[ar][bc]; // Product
          for(int row = 0; row < ar; row++) {
            for(int col = 0; col < bc.lenght) {
               for(int i = 0; i < ac; i++) {
                  p[row][column] += a[row][i] * b[row][i] 
               }
            }
          }
          
          return p;
        }
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

            //Probabilidad 
            Console.WriteLine("\n\n Probabilidad \n");

            float t[4][4] = { // Transition Matrix
              // Col 1  Col 2   Col 3   Col 4
              { 0.166f, 0.333f, 0.333f, 0.166f }, // Row 1
              //[0,0]  [0,1]    [0,2]   [0,3]
              { 0.166f, 0.166f, 0.333f, 0.333f }, // Row 2
              //[1,0]  [1,1]    [1,2]   [1,3]
              { 0.333f, 0.166f, 0.166f, 0.333f }, // Row 3
              //[2,0]  [2,1]    [2,2]   [2,3]
              { 0.333f, 0.333f, 0.166f, 0.166f }  // Row 4
              //[3,0]  [3,1]    [3,2]   [3,3]
            };
          
            float r[4][4] = { // Result Matrix
                // Col 1  Col 2   Col 3   Col 4
                { 0.166f, 0.333f, 0.333f, 0.166f }, // Row 1
                //[0,0]  [0,1]    [0,2]   [0,3]
                { 0.166f, 0.166f, 0.333f, 0.333f }, // Row 2
                //[1,0]  [1,1]    [1,2]   [1,3]
                { 0.333f, 0.166f, 0.166f, 0.333f }, // Row 3
                //[2,0]  [2,1]    [2,2]   [2,3]
                { 0.333f, 0.333f, 0.166f, 0.166f }  // Row 4
                //[3,0]  [3,1]    [3,2]   [3,3]
              };

            float initialProb[4] = { 0.166f, 0.333f, 0.333f, 0.166f };
          
            float r[4] = { 4.2f, 2.2f, 6f, 9f }; // Retribution array
            

            float[,] transicionN;
            float[,] transicionTemp;
            float[,] probNLanzamientos;

            //transicion a la n
            float tn[4][4] = new float[4][4];
            for(int i = 0; i < cantidadTiros; i++) {
              tn += multiplyMatrix(t, t);// accumulate result
            }
            float res = multiplyMatrix(initialProb, tn);


            Console.WriteLine(transicionTemp[0, 0] + " " + transicionTemp[0, 1] + " " + transicionTemp[0, 2] + " " + transicionTemp[0, 3] + " ");
            Console.WriteLine(transicionTemp[1, 0] + " " + transicionTemp[1, 1] + " " + transicionTemp[1, 2] + " " + transicionTemp[1, 3] + " ");
            Console.WriteLine(transicionTemp[2, 0] + " " + transicionTemp[2, 1] + " " + transicionTemp[2, 2] + " " + transicionTemp[2, 3] + " ");
            Console.WriteLine(transicionTemp[3, 0] + " " + transicionTemp[3, 1] + " " + transicionTemp[3, 2] + " " + transicionTemp[3, 3] + " ");
        }
    }
}
