#include "Dog.h"

// This function gets the premium that will be calculated with discounts
// based on the weight and ages the user will enter.
float Dog::getPremium() {
    // it sets premium to be equal to the premium that is found by comparing
    // the riskweight and the weight of the dog
    this->premium = this->getBasePremium();
    if(this->isSubjectToDiscount) {
        if(this->age > 13) {
            this->premium = this->premium - (0.2 * this->premium);
        }
        if(this->weight > 50) {
            this->premium = this->premium + (0.25 * this->getBasePremium());
        }
    }
    return this->premium;
}

// This function will get the base premium which is based on the comparison
// between weight and riskweight will we determine it is higher premium or
// lower premium.
float Dog::getBasePremium() {
    if(this->weight >= this->riskWeight) {
        this->premium = this->atOrAboveRiskWeight;
    } else {
        this->premium = this->belowRiskWeight;
    }
    return this->premium;
}

// The deconstructor, could use this to save more memory, good memory management
Dog::~Dog() {
//    cout << "Goodye " << this->name << endl;
}

// We define each member of each breed which is derived from the Dog class
// but its values are set in each breed class
Pitbull::Pitbull(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Pitbull";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = false;
    this->riskWeight = 0;
    this->belowRiskWeight = 30.20;
    this->atOrAboveRiskWeight = 35.15;
}

Doberman::Doberman(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Doberman";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = true;
    this->riskWeight = 35;
    this->belowRiskWeight = 28.16;
    this->atOrAboveRiskWeight = 30.00;
}

Rottweiler::Rottweiler(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Rottweiler";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = false;
    this->riskWeight = 45;
    this->belowRiskWeight = 28.00;
    this->atOrAboveRiskWeight = 29.75;
}

GermanShepherd::GermanShepherd(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "German Shepherd";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = true;
    this->riskWeight = 30;
    this->belowRiskWeight = 27.50;
    this->atOrAboveRiskWeight = 29.75;
}

ChowChow::ChowChow(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Chow Chow";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = true;
    this->riskWeight = 24;
    this->belowRiskWeight = 25.10;
    this->atOrAboveRiskWeight = 27.50;
}

GreatDane::GreatDane(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Great Dane";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = true;
    this->riskWeight = 55;
    this->belowRiskWeight = 25.10;
    this->atOrAboveRiskWeight = 25.20;
}

PresaCanario::PresaCanario(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Presa Canario";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = false;
    this->riskWeight = 45;
    this->belowRiskWeight = 20.01;
    this->atOrAboveRiskWeight = 20.55;
}

Akita::Akita(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Akita";
    this->age = age;
    this->weight = weight;
    this->riskWeight = 0;
    this->belowRiskWeight = 19.75;
}

AlaskanMalamute::AlaskanMalamute(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Alaskan Malamute";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = true;
    this->riskWeight = 38;
    this->belowRiskWeight = 15.50;
    this->atOrAboveRiskWeight = 18.15;
}

Husky::Husky(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Husky";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = true;
    this->riskWeight = 20;
    this->belowRiskWeight = 9.95;
    this->atOrAboveRiskWeight = 12.00;
}

OtherBreed::OtherBreed(string name, int age, int weight) : Dog() {
    this->name = name;
    this->breed = "Other Breed";
    this->age = age;
    this->weight = weight;
    this->isSubjectToDiscount = false;
    this->riskWeight = 35;
    this->belowRiskWeight = 4.95;
    this->atOrAboveRiskWeight = 8.95;
}

