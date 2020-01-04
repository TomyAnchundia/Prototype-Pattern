using System;
using PrototypePattern.Clase;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern");

            Estudiante estudiante1 = new Estudiante() { Nombre = "Tomy", Identidad = "1313364414", Edad = 22 };  //instanciamos un estudiante
            Estudiante estudianteClonado = estudiante1;        //Se clona un estudiante con los mismos datos    
            estudianteClonado.Edad = 25;                       // cambiamos la edad del estudiante clonado y los cambios afectaran al estudianclonado y al original

            /* LO CORRECTO PARA IMPLEMENTAR LA CLONACION  */
            Estudiante estudianteClonado = estudiante1.Clone() as Estudiante;  //el cambio de la edad solo se provocara en el clone
            Console.WriteLine(estudiante1.Nombre);

        }
    }
}
