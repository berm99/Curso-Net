using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases;  //es el nombre del proyecto , si ponemos EjemploClases; se quitan los corchetes 

public class Coche //public, private, internal: significa que solo se ve dentro deste proyecto
{
    //mejor que las clases sean public
    string Marca;
    string Modelo;
    string Color;
    double Consumo;
    int Cilindrada;
    int NumeroPuertas;
    int NumeroRuedas;
    int NumeroAsientos;
    private Motor Motor;
}
