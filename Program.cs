using System;

namespace TPFinal_Díaz
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se 
        // ingresa un cero. A partir de dichos datos informar:
        // a. El mayor de los números pares.
        // b. La cantidad de números impares.
        // c. El menor de los números primos.

        // NOTA: Evaluar el uso de una función que analice si un número dado es primo ó no y 
        // que devuelva true o false según correspoda.
            
            int n;
            int par, parMayor=0, contImpar=0;
            int primoMenor=0;
            bool banPrimo= false;

            Console.WriteLine("Ingrese un N°: ");
            n=int.Parse(Console.ReadLine());        
            while (n!=0)
            {
                if(n%2==0){
                    par=n;
                   if(par>parMayor)
                      parMayor=par;
                }else 
                    contImpar++;
                if(primo(n)==true){
                   if(banPrimo==false){
                      primoMenor=n;
                      banPrimo=true;
                   }else if(n<primoMenor)
                            primoMenor=n;
                }   
                ingreso(ref n);
            }
            Console.WriteLine("El mayor de los N° par es: " + parMayor);
            Console.WriteLine("El total de N° impar es: " + contImpar);
            Console.WriteLine("El menor de los N° primo es: " + primoMenor);   
        }
        static void ingreso(ref int a){
             Console.WriteLine("Ingrese otro N° ó cero para finalizar. ");
             a=int.Parse(Console.ReadLine());
        }
        static bool primo(int a){
            int cont=0;
            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                   cont++;
            }
            if(cont == 2)
                return true;
            else
                return false;
        }
    
    }
}
