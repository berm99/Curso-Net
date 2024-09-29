using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploClases
{
    public class Empleado
    {
        public string Nombre
        {
            get;
            set;
            
            
        }

        public string Departamento
        {
            get;
            set;
            
                    }
        public string Telefono { get; set; }
        public string numeroEmpleado { get; set; }
        public string NSS { get; set; }
        public string IBAN { get; set; }

        //Metodo (Funcion)
        public void MostrarDatosEmpleado()
        {
            Console.WriteLine("Nombre empleado: " +Nombre+ "Departamento: " + Departamento);
            Console.WriteLine("Nombre empleado: {0} Departamento: {1}", Nombre, Departamento);
            Console.WriteLine($"Nombre empleado: {Nombre} Departamento: {Departamento}");

        }
    }
}