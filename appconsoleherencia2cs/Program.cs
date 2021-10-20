using System;

namespace appconsoleherencia2cs
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Alumno  a;
            a = new Alumno ("Julio Cesar Quirino Bueno", "23/09/2000", "Programacion", "I21050348");
            Console.WriteLine(a.ToString());
            Console.ReadLine();

        }
        
    }
}
