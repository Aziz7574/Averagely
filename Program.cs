using System;

namespace Space{
    public class Program{
        public static void Main()  
        {
            Console.WriteLine("Enter your five grades that you have received from school");

            Console.WriteLine("Chemistry - >"); 
            float chemistry = float.Parse(Console.ReadLine());  

            Console.WriteLine("Math - >"); 
            float math = float.Parse(Console.ReadLine());  

            Console.WriteLine("Geography - >"); 
             float geography = float.Parse(Console.ReadLine());  


           Console.WriteLine("Pyhsic - >"); 
                    float physic = float.Parse(Console.ReadLine());  

            Console.WriteLine("IT - >"); 
                    float it = float.Parse(Console.ReadLine());   

            float average  = (it + physic + geography + math + chemistry)/5;   

            if(average <= 5 && average >= 3){
               Console.WriteLine($"Your average grade from every one  is {average}");
               Console.WriteLine("You have passed the exam"); 
               Console.WriteLine("Congratulations");
            }
            else if(average >= 0 && average <= 3){
                Console.WriteLine("You didn't pass");
                Console.WriteLine("Please try again");
            }
            else
            Console.WriteLine("Your grades could not qulify our standarts");

            
        }
    }
}