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
                //var personas = dbContext.Personas.Where( p => p.nombre =="Viridiana").ToList();
                //List<Personas> personas = dbContext.Personas.Where(p => p.edad >= 25 && p.edad <= 30).ToList();

                /* foreach(Personas persona in personas)
                {
                    Console.WriteLine(persona.nombre + persona.apellido);
                    Console.WriteLine(persona.apellido);
                    
                }*/

                Personas persona = new Personas();

                Console.ReadKey();
            }
        }

    }
}
