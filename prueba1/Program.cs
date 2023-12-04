using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("FIBONACCI");
        Console.WriteLine("1. ");
        Console.WriteLine("2.  ");
        Console.WriteLine("3.  ");
        Console.WriteLine("4. SALIR");
        Console.WriteLine("Ingrese una opcion: ");
        var opcion = Convert.ToInt32(Console.ReadLine());
        bool controlador = true;
        while (controlador)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    numFibo();
                    break;


                case 2:
                    Console.Clear();
                    sinoNumFib();
                    break;

                case 3:
                    Console.Clear();
                    primerNum();
                    break;

                case 4:
                    Console.Clear();
                    controlador = false;
                    break;

                default:
                break;
            }
        }
        
    }

    public static void  numFibo()
        {
            Console.WriteLine("Escriba un numero entero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Ingrese un numero positivo");
    
            }
            else 
            {
                int a =0,b=1, resultado= a+b;
                a = b;
                b= resultado;
                resultado = a+b;
                Console.WriteLine($"f{n}");
            }
        }

    public static void sinoNumFib()
    {
        Console.WriteLine("Ingrese un numero entero: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
    }


    public static void primerNum()
    {
        Console.WriteLine("Ingrese un numero entero: ");
    }
}


