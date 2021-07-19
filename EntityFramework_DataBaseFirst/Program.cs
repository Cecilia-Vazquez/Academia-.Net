using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PersonasEntities dbContext = new PersonasEntities())

            {
                //var personas = dbContext.Personas.Where( p => p.nombre =="Viridiana").ToList();   Consulta
                //List<Personas> personas = dbContext.Personas.Where(p => p.edad >= 25 && p.edad <= 30).ToList();

                /* foreach(Personas persona in personas)
                {
                    Console.WriteLine(persona.nombre + persona.apellido);
                    Console.WriteLine(persona.apellido);
                    
                }*/



                /* Personas persona = new Personas();    Agreagar registro
                persona.nombre = "Viry";
                persona.apellido = "Flores";
                persona.edad = 34;
                persona.idGenero = 1;

                dbContext.Personas.Add(persona);*/

                var persona = dbContext.Personas.Where(p => p.id == 10).SingleOrDefault();

                //persona.apellido = "Ortiz";  Modificacion
                //dbContext.Entry(persona).State = System.Data.Entity.EntityState.Modified;

                dbContext.Personas.Remove(persona);




                try
                {
                    dbContext.SaveChanges();
                    Console.WriteLine("Persona eliminada");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);

                }


                Console.ReadKey();
            }
        }

    }
}
