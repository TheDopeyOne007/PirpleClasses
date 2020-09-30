using System;

namespace animal
{
    class animal
    {
        static void Main(string[] args)
        {
            // Animal: Lion
            // File to describe the lion with the following attributes:
            Console.WriteLine("CHARACTERISTICS:");
            int lifespan = 12; // number of years a lion can live
            short numberOfClaws = 18; // number of claws a lion has
            long currentPopulation = 20147; // approximation of lions left in the wild

            uint numberOfFeet = 4;  // number of feet the lion has
            ushort lengthOfTailInMeters = 1; // the length of the tail in meters
            ulong numberOfTeeth = 30; // number of teeth the lion has

            byte weightInKilos = 250; // weight of the lion in kilos
            sbyte heightOfJumpInFeet = 11; // the height a lion can jump

            float bodyLengthInMeters = 2.1123f; // the body length of the lion in meters
            double speedInKmH = 79.654532432; // average speed of a running lion in km/h

            bool isMammal = true; // boolean for lion whether it is mammal or not

            char firstLetterOfAnimal = 'L'; // holds the first letter of the name of the animal

            Console.WriteLine(lifespan);
            Console.WriteLine(numberOfClaws);
            Console.WriteLine(currentPopulation);
            Console.WriteLine(numberOfFeet);
            Console.WriteLine(lengthOfTailInMeters);
            Console.WriteLine(numberOfTeeth);
            Console.WriteLine(weightInKilos);
            Console.WriteLine(heightOfJumpInFeet);
            Console.WriteLine(bodyLengthInMeters);
            Console.WriteLine(speedInKmH);
            Console.WriteLine(isMammal);
            Console.WriteLine(firstLetterOfAnimal);
        }
    }
}
