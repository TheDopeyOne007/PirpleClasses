using System;

namespace homework4
{
    class homework4
    {
        // An enum to hold all the activities of a lion
        enum LionsActions {
            Hunting, Eating, Protecting, Mating, Leading  
        }

        // An enum to hold all the common prey that the lion eats
        enum LionsFood {
            Wildebeests, Zebras, Antelopes, Gazelle, Hippos
        }
        static void Main(string[] args)
        {
            // A string array that holds different names for the lion
            string[] namesOfLion = new string[3];
            namesOfLion[0] = "Pathera Leo";
            namesOfLion[1] = "Ari";
            namesOfLion[2] = "Lejon";

            // a string array to hold the name of some subspecies under lion
            string[] subspeciesOfLion = new string[3];
            subspeciesOfLion[0] = "P. l. leo";
            subspeciesOfLion[1] = "P. l. melanochaita";
            subspeciesOfLion[2] = "P. l. sinhaleyus";

            // a int array to hold different weights of a male lion from around the world
            int[] weightsOfLionKilos = new int[3];
            weightsOfLionKilos[0] = 225;
            weightsOfLionKilos[1] = 175;
            weightsOfLionKilos[2] = 190;

            // A string to hold the common sound of the lion
            string soundOfLion = "Roar!";

            // The meta data from the first assignment
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
