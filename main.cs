using System;

class Program {
  public static void Main (string[] args) {
    
    // declaring variables
    double total = 0;
    int i;
    
    Console.WriteLine("How many cars do you have");
    int numberofcars = Convert.ToInt32(Console.ReadLine());  
    
    
     for(i=1;i<=numberofcars;i++){
    // These statements will go in a loop //
     
    Console.WriteLine("Enter the distance covered by car#" +i );
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter time taken by car#" +i );
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = distance/time;
    Console.WriteLine("The speed of this car is " + speed + " miles per hour " );
    total = total + speed;
    
    
    }

    double average = total/numberofcars;
    Console.WriteLine("The average speed of your " +  numberofcars  +  " cars " + "are " + average);
    

    

    

    


  }
}
