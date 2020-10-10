// homework 11
#include <iostream>
#include <iomanip>
#include <string>
#include <cstdio>
#include <locale>
#include <cmath>
#include "Dog.h"

using namespace std;

// So this is my main function for this whole project, it will ask for the details
// and through my Dog class and the classes of each class that is derived from
// the Dog class it will give out the premium based on the weight and age that
// the user will input about their dog.
//
// The user will input a number that will be the number of dogs the owner will
// input and then we get the details of each dog.
//
// It will identify the breed based on the breed code
// and then will create an object of each dog that could be placed in a list or saved into
// a database. Then it will calculate the total premium for the whole household.
int main() {
    cout << setiosflags(ios::fixed);
    cout << setprecision(2);
    int dogCount = 0;
    float totalPremium = 0;
    string sTotalPremium;
    cout << "Please enter the number of dogs in your household: ";
    cin >> dogCount;
    float basePremium;
    int weight, age;
    char breedCode;
    string dogName;
    string currentBreed = "None";
    int inputNo = 1;
    char separator = std::use_facet< std::numpunct<char> >(std::cout.getloc()).thousands_sep();

    while(inputNo <= dogCount) {
        bool validInput = true;
        cin.ignore();
        printf("\nEnter the name of dog #%d: ", inputNo);
        getline(cin, dogName);
        printf("Enter the breed code for %s: ", dogName.c_str());
        cin >> breedCode;
        // I used a switch here to identify the breed based on
        // the breedCode
        switch(breedCode) {
            case 'p':
                printf("%s is a Pitbull", dogName.c_str());
                break;
            case 'd':
                printf("%s is a Doberman", dogName.c_str());
                break;
            case 'r':
                printf("%s is a Rottweiler", dogName.c_str());
                break;
            case 'g':
                printf("%s is a German Shepherd", dogName.c_str());
                break;
            case 'c':
                printf("%s is a Chow Chow", dogName.c_str());
                break;
            case 't':
                printf("%s is a Great Dane", dogName.c_str());
                break;
            case 's':
                printf("%s is a Presa Canario", dogName.c_str());
                break;
            case 'k':
                printf("%s is an Akita", dogName.c_str());
                break;
            case 'm':
                printf("%s is an Alaskan Malamute", dogName.c_str());
                break;
            case 'h':
                printf("%s is a Husky", dogName.c_str());
                break;
            default:
                printf("Sorry. That is not a valid breed code. Please re- enter this dog’s information.");
                validInput = false;
        }
        if(!validInput) {
            continue;
        }
        cout << "\n";
        printf("Enter the current age for %s: ", dogName.c_str());
        cin >> age;
        printf("Enter the weight for %s (nearest kg): ", dogName.c_str());
        cin >> weight;
        // Here is where each object is created and called, where
        // we call the function to calculate the basePremium and save it to basePremium
        if(breedCode == 'p') {
            Pitbull newPB = Pitbull(dogName, age, weight);
            basePremium = newPB.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'd') {
            Doberman newDB = Doberman(dogName, age, weight);
            basePremium = newDB.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'r') {
            Rottweiler newR = Rottweiler(dogName, age, weight);
            basePremium = newR.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'g') {
            GermanShepherd newGS = GermanShepherd(dogName, age, weight);
            basePremium = newGS.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'c') {
            ChowChow newCC = ChowChow(dogName, age, weight);
            basePremium = newCC.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 't') {
            GreatDane newGD = GreatDane(dogName, age, weight);
            basePremium = newGD.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 's') {
            PresaCanario newPC = PresaCanario(dogName, age, weight);
            basePremium = newPC.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'k') {
            Akita newA = Akita(dogName, age, weight);
            basePremium = newA.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'm') {
            AlaskanMalamute newAM = AlaskanMalamute(dogName, age, weight);
            basePremium = newAM.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'h') {
            Husky newH = Husky(dogName, age, weight);
            basePremium = newH.getPremium();
            totalPremium += basePremium;
        } else if(breedCode == 'b'){
            OtherBreed newOB = OtherBreed(dogName, age, weight);
            basePremium = newOB.getPremium();
            totalPremium += basePremium;
        }
        // We print the premium of each dog which is saved in basePremium
        // and it changes each iteration to hold the current dog's premium price
        printf("The monthly premium for %s is %.2f\n", dogName.c_str(), basePremium);
        inputNo++;
    }
    // We print the total premium after the whole every dog's details are inputted
    printf("\nThe total monthly premium for all dogs is %.2f\n", totalPremium);
    return 0;
}
