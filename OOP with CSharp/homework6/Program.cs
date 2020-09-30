using System;

namespace homework6
{
    class Vehicle {
        public bool NeedsMaintenance = false;
        public int TripsSinceMaintenance = 0;
        private string make, model;
        private int year;
        private float weight;
        public string Make {
            get {return make;}
            set {make = value;}
        }
        public string Model {
            get {return model;}
            set {model = value;}
        }
        public int Year {
            get {return year;}
            set {year = value;}
        }
        public float Weight {
            get {return weight;}
            set {weight = value;}
        }
        public void Repair() {
            TripsSinceMaintenance = 0;
            NeedsMaintenance = false;
        }
    }

    class Cars : Vehicle {
        private bool isDriving = false;
        public void Drive() {
            isDriving = true;
            // Console.WriteLine("{0} from drive()", TripsSinceMaintenance);
        }
        public void Stop() {
            // this makes sure that you need to start driving first then when you stop, thats
            // when you add one to trips since maintenance and then set to false 
            if(isDriving) {
                TripsSinceMaintenance++;
                if(TripsSinceMaintenance >= 101) {
                NeedsMaintenance = true;
                }
            } 
            // once it needs maintenance it will repair and set needsmaintenance to false
            // and set trips since maintenance to 0, so if it is greater than or equal to 101 which is above 100
            // it will need maintenance
            if(NeedsMaintenance) {
                Repair();
            }
            // Console.WriteLine("{0} from stop()", TripsSinceMaintenance);
            isDriving = false;
        }
    }

    class Planes: Vehicle {
        private bool isFlying = false;
        public void Flying() {
            if(NeedsMaintenance) {
                Console.WriteLine("Plane needs maintenance! Try again later!");
                NeedsMaintenance = true;
                isFlying = false;
            } else {
                isFlying = true;
            }
        }
        public void Landing() {
            if(isFlying) {
                TripsSinceMaintenance++;
                if(TripsSinceMaintenance >= 101) {
                NeedsMaintenance = true;
                }
            } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] noOfTrips = new int[3] {63, 104, 202};
            Cars carA = new Cars();
            Cars carB = new Cars();
            Cars carC = new Cars();
            Planes planeA = new Planes();

            carA.Make = "Ford";
            carA.Model = "EcoSport";
            carA.Year = 2018;
            carA.Weight = 200;

            carB.Make = "Ford";
            carB.Model = "Mustang";
            carB.Year = 2014;
            carB.Weight = 300;

            carC.Make = "Pajero";
            carC.Model = "Mini";
            carC.Year = 2008;
            carC.Weight = 250;

            planeA.Make = "Emirates";
            planeA.Model = "A380-800";
            planeA.Year = 2020;
            planeA.Weight = 10000;

            for(int i = 0; i < noOfTrips[0]; i++) {
                carA.Drive();
                carA.Stop();
            }
            for(int i = 0; i < noOfTrips[1]; i++) {
                carB.Drive();
                carB.Stop();
            }
            for(int i = 0; i < noOfTrips[2]; i++) {
                carC.Drive();
                carC.Stop();
            }

            // need maintenance will always be false cause the function repair will always be called
            // the moment tripsSinceMaintenance is beyond 100 or equal to 101 or greater than, ex. 202 will experience maintenance twice since its at 101, so its tripSinceMaintenance will be 0 
            // if we remove the the call for repair in the function above, it will result to true since it will exceed 101 and no repairs will be made
            Console.WriteLine("CarA: {0} {1} {2} {3} {4}", carA.Make, carA.Model, carA.Year, carA.NeedsMaintenance, carA.TripsSinceMaintenance);
            Console.WriteLine("CarB: {0} {1} {2} {3} {4}", carB.Make, carB.Model, carB.Year, carB.NeedsMaintenance, carB.TripsSinceMaintenance);
            Console.WriteLine("CarC: {0} {1} {2} {3} {4}", carC.Make, carC.Model, carC.Year, carC.NeedsMaintenance, carC.TripsSinceMaintenance);

            Console.WriteLine();
            Console.WriteLine("Plane A: ");
            
            // So after 100, there should be 6 attempts to fly but we won't allow that
            for(int i = 0; i < 106; i++) {
                planeA.Flying();
                planeA.Landing();
            }

            // TripsSinceMaintenance will be equal to 101 always if it goes beyond 100 since it will deny trips due to the need
            // for maintenance
            Console.WriteLine("PlaneA: {0} {1} {2} {3} {4}", planeA.Make, planeA.Model, planeA.Year, planeA.NeedsMaintenance, planeA.TripsSinceMaintenance);
        }
    }
}
