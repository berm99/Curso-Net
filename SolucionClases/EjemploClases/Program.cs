namespace EjemploClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Coche FordMondeo = new Coche();
            Coche FerrariTestarosa = new Coche();
            Coche SkodaFabia = new Coche();
            Coche CitroenXs = new Coche();
            Coche SeatIbiza = new Coche();
            Coche RenaultClio = new Coche();
            Coche Peugeot206 = new Coche();
            Coche OpelCorsa = new Coche();
            Coche NissanMicra = new Coche();
            Coche Mazda2 = new Coche();

            FordMondeo.Marca = "Ford";
            FordMondeo.Color = "Azul";
            FordMondeo.Cilindrada = 2000;
            FordMondeo.Modelo = "Mondeo";
            FordMondeo.NumeroAsientos = 5;
            FordMondeo.NumeroRuedas = 4;
            FordMondeo.NumeroPuertas = 5;
            FordMondeo.MotorCoche = new Motor();
            FordMondeo.MotorCoche.Cilindrada = 2000;
            FordMondeo.MotorCoche.Consumo = 5.5;
            FordMondeo.MotorCoche.Potencia = 150;
            FordMondeo.MotorCoche.Combustible = "Gasolina";

            //Creamos instancias de los empleados
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();
            Empleado empleado3 = new Empleado();

            empleado1.Nombre = "Pedro";
            empleado1.Departamento = "IT";
            empleado1.MostrarDatosEmpleado();
            empleado2.Nombre = "Maria";
            empleado2.Departamento = "Desarrollo";
            empleado3.Nombre = "Juan";
            empleado3.Departamento = "RRHH";

            empleado1.MostrarDatosEmpleado();
            empleado2.MostrarDatosEmpleado();
            empleado3.MostrarDatosEmpleado();

        }
    }

    //Puede haber varias clases en un mismo archivo pero varias clases dentro de una clase es extraño



}
