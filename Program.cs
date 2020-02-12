using System;

namespace Rober
{
    class Rober
    {
        private string nombre;
        private int edad;
        private string correo;
    
        public string getNombre(){
            return nombre;
        }
        public void setNombre(string n)
        {
            nombre =n;
        }
         public int getEdad()
        {
            return edad;
        }public void setEdad(int e)
        {
            edad = e;
        }
       
        public string getCorreo()
        {
            return correo;
        }
        public void setCorreo(string c)
        {
           correo=c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rober p= new Rober();
            p.setNombre("Ana");
            p.setEdad(18);
            p.setCorreo("maquinitadeamor@yimeil.com");
            
            Rober p2=new Rober();
            p2.setEdad(787);
            p2.setNombre("Johnny");
            p2.setCorreo("otramaquinita@jaifaib.com");

            Console.WriteLine(p.getNombre());
            Console.WriteLine(p2.getNombre());
            Console.WriteLine(p.getCorreo());
            Console.WriteLine(p.getEdad());
            Console.WriteLine(p2.getCorreo());
            Console.WriteLine(p2.getEdad());
        }
    }
}
