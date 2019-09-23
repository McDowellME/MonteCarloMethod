using System;

namespace MonteCarloMethod
{
    class Program
    {
        //Create a function which takes an x, y coordinate struct and 
        //returns a double corresponding to the hypotenuse of a triangle with sides of lengths x, y.
        public static double sidesOfTriangle(Coordinates coordinates)
        {
            //Pythagorean theorem, hypotenuse=√(x^2+y^2 )
            double hypotenuse;
            double xSquared = coordinates.x * coordinates.x;
            double ySquared = coordinates.y * coordinates.y;

            hypotenuse = Math.Sqrt(xSquared + ySquared);

            return hypotenuse;
        }
        static void Main(string[] args)
        {
            //Build a Main method 
            //which takes one int parameter from the command line and 
            //creates an array of that length containing randomly initialized coordinates.
            Console.WriteLine("main.MonteCarloMethod()");
            Console.WriteLine("How many coordinates do you want to test?");
            string userInput = Console.ReadLine();
            int userInputParse = int.Parse(userInput);
            Coordinates[] coordinatesArray = new Coordinates[userInputParse];

            //Iterate over the array, 
            //incrementing a counter for each coordinate which overlaps the unit circle.

            //you can classify the pairs into those that overlap the unit circle (hypotenuse<= 1, blue shaded area) 
            //and those that fall outside the unit circle (hypotenuse>1, red shaded area). 
            //The ratio of pairs that overlap the unit circle divided by 
            //the total number of pairs generated is the area of the unit circle in the top right quadrant.

            int counter = 0;

            for (int i = 0; i < coordinatesArray.Length; i++)
            {
                coordinatesArray[i] = new Coordinates(new Random());
                double hypotenuse = sidesOfTriangle(coordinatesArray[i]);

                if(hypotenuse <= 1)
                {
                    counter++;
                }
            }


            //Using the Length parameter of the array, divide the number of coordinates overlapping the unit circle 
            //by the number of array elements. Multiply this value by 4.

            double piEstimate = ((double)counter / (double)coordinatesArray.Length) * 4;

            //Print the value from step #4 along with the 
            //absolute value of the difference between your estimate of π and Math.Pi.

            Console.WriteLine($"The number of coodinates that overlap the unit circle is {counter}");
            Console.WriteLine($"The difference between my Pi estimate and Math.PI is {Math.Abs(piEstimate - Math.PI)}");

            //Run your program, passing 10, 100, 1000, and 10000 as the command line parameter. 
            //Record the output of your program.
            //10 
            //The number of coodinates that overlap the unit circle is 7
            //The difference between my Pi estimate and Math.PI is 0.341592653589793

            //100
            //The number of coodinates that overlap the unit circle is 71
            //The difference between my Pi estimate and Math.PI is 0.301592653589793

            //1000
            //The number of coodinates that overlap the unit circle is 797
            //The difference between my Pi estimate and Math.PI is 0.0464073464102071

            //10000
            //The number of coodinates that overlap the unit circle is 7809
            //The difference between my Pi estimate and Math.PI is 0.017992653589793

            //#1 Why do we multiply the value from step 5 above by 4?
            //Because the number only represents a quadrant and you need to multiply it
            //by four to see the full circle.

            //#2 What do you observe in the output when running your program with parameters of increasing size?
            //When increasing the test size, the difference between the two numbers decreases.

            //#3 If you run the program multiple times with the same parameter, does the output remain the same? 
            //No
            //Why or why not?
            //Because the coordinates provide random numbers, the number that overlap will always change

            //#4 Find a parameter that requires multiple seconds of run time. What is that parameter ?
            //10,000
            //How accurate is the estimated value of π?
            //Much more accurate, have a much smaller difference

            //#5 Research one other use of Monte - Carlo methods.
            //Record it in your exercise submission and be prepared to discuss it in class.
            //Particle Physics



            
        }
}
}
