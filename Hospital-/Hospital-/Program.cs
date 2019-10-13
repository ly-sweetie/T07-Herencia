using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asignar propiedades a los objetos
            Paciente p = new Paciente();
            p.Nombre = "Alexis";
            p.FechaNacimiento = "24 Agosto 2000";
            p.Telefono = "664728638";
            Console.WriteLine(p.Nombre + p.FechaNacimiento +p.Telefono);
            Console.WriteLine("  ");
            Console.ReadKey();


            Enfermera E = new Enfermera();
            E.Nombre = "Ruben";
            E.FechaNacimiento = "14 Febrero 1998";
            E.Telefono = "6644857920";
            E.Area = "Enfermeria";
            Console.WriteLine(E.Nombre + E.FechaNacimiento +  E.Telefono + E.Area);
            Console.WriteLine("  ");
            Console.ReadKey();

            Mujer muj = new Mujer();
            muj.Nombre = "Monica";
            muj.FechaNacimiento = "25 de Agosto del 2000";
            muj.Telefono = "665283049";
            muj.Enfermedad = "Estomago";
            Console.WriteLine(muj.Nombre +  muj.FechaNacimiento +  muj.Telefono);
            Console.WriteLine("  ");
            Console.ReadKey();

            Hombre hom = new Hombre();
            hom.Nombre = "Manuel";
            hom.FechaNacimiento = "16 de Agosto del 1996";
            hom.Telefono = "6645654956";
            hom.Enfermedad = "Gripe";
            Console.WriteLine(hom.Nombre +  hom.FechaNacimiento +  hom.Telefono);
            Console.ReadKey();

            Fisoterapeuta fis = new Fisoterapeuta();
            fis.Nombre = "Mordecai";
            fis.FechaNacimiento = "30 Septiembre 1990";
            fis.Telefono = "6640875472";
            fis.Especialidad = "Fisioterapeuta";
            Console.WriteLine(fis.Nombre +  fis.FechaNacimiento +  fis.Telefono + fis.Especialidad);
            Console.ReadKey();

            Familiar fam = new Familiar();
            fam.Nombre = "Adrian";
            fam.FechaNacimiento = "18 Enero 1987";
            fam.Telefono = "664556867";
            fam.Especialidad = "Medico General";
            Console.WriteLine(fam.Nombre +  fam.FechaNacimiento +  fam.Telefono + fam.Especialidad);
            Console.ReadKey();

            Cirujano Cir = new Cirujano();
            Cir.Nombre = "Karina";
            Cir.FechaNacimiento = "7 Agosto 1989";
            Cir.Telefono = "6649762912";
            Cir.Especialidad = "Cirujano";
            Console.WriteLine(Cir.Nombre  + Cir.FechaNacimiento + Cir.Telefono + Cir.Especialidad);
            Console.ReadKey();

            Medico med = new Medico();
            med.Nombre = "Rigby";
            med.FechaNacimiento = "26 Noviembre 1991";
            med.Telefono = "664845217";
            med.Especialidad = "Medico general";
            Console.WriteLine(med.Nombre +  med.FechaNacimiento +  med.Telefono +  med.Especialidad);
            Console.ReadKey();
        }
    }
}
