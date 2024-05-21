using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyrehjelpen
{
    internal class Kidneys
    {
        public string KidneyName { get; private set; }
        public int KidneyHealth { get; set; }
      
        
        bool isHealthy = false;

        public Kidneys(string kidneyName, int kidneyHealth)
        {
            KidneyName = kidneyName;
            KidneyHealth = kidneyHealth;
            
           
          
        }
        public void addKidney()
        {
          
            string input = Console.ReadLine();

            if(input == "0" ) 
            {
             
                Console.WriteLine("Bernt has died. Good job");
            }
            else if (input == "1")
            {
                Console.WriteLine("You have chosen the kidney with a health of" + KidneyHealth + "You should probably not choose this one");
            }
            else if(input == "2")
            {
                Console.WriteLine("You have chosen the kidney with a health of" + KidneyHealth + "You should probably choose this one");
            }
            
        }
    }
}
