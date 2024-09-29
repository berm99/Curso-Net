using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases;  //es el nombre del proyecto , si ponemos EjemploClases; se quitan los corchetes 

public class Coche //public, private, internal: significa que solo se ve dentro deste proyecto
{
    //es importante tener propiedades en lugar de campos
    //para convertir un campo en una propiedad ponemos public y {get; set;} 
    //mejor que las clases sean public
    //string Marca; campo
    public string Marca { get; set; } //propiedad
    //string Modelo; por defecto es privado entonces desde otras clases no podemos utilizarlo, ya que no es visible
    
    public string Modelo { get; set; }
    public string Color { get; set; }
    public double Consumo { get; set; }
    public int Cilindrada { get; set; }
    public int NumeroPuertas { get; set; }
    public int NumeroRuedas { get; set; }
    public int NumeroAsientos { get; set; }
    public Motor MotorCoche { get; set; }
}
