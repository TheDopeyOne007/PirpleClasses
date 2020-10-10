//
// Created by Anthony Heitzeberg on 10/3/20.
//
// This is the Dog header file where we hold all the classes with their members and
// methods, then it will be defined in the Dog.cpp, for Akita, we override the function
// right here to just return the lower premium.

// Here is where each breed is created and derived from the Dog class as its based class
// and we set all their properties in the Dog.cpp
// I place the members under protected so that only within the base and derived classes can
// it be accessed.
#ifndef WOOFFURS_DOG_H
#define WOOFFURS_DOG_H

#include <iostream>
#include <string>

using namespace std;
class Dog {
public:
    float getPremium();
    ~Dog();
protected:
    string name;
    string breed;
    bool isSubjectToDiscount;
    int age, weight;
    float premium;
    float riskWeight;
    float belowRiskWeight;
    float atOrAboveRiskWeight;
    virtual float getBasePremium();
};

class Pitbull : public Dog {
public:
    Pitbull(string name, int age, int weight);
};

class Doberman : public Dog {
public:
    Doberman(string name, int age, int weight);
};

class Rottweiler : public Dog {
public:
    Rottweiler(string name, int age, int weight);
};

class GermanShepherd : public Dog {
public:
    GermanShepherd(string name, int age, int weight);
};

class ChowChow : public Dog {
public:
    ChowChow(string name, int age, int weight);
};

class GreatDane : public Dog {
public:
    GreatDane(string name, int age, int weight);
};

class PresaCanario : public Dog {
public:
    PresaCanario(string name, int age, int weight);
};

class Akita : public Dog {
public:
    Akita(string name, int age, int weight);
    // overrides the function to just return the blower premium when
    // the dog's breed is Akita
protected:
    float getBasePremium() override {
        return this->belowRiskWeight;
    }
};

class AlaskanMalamute : public Dog {
public:
    AlaskanMalamute(string name, int age, int weight);
};

class Husky: public Dog {
public:
    Husky(string name, int age, int weight);
};

class OtherBreed : public Dog {
public:
    OtherBreed(string name, int age, int weight);
};

#endif //WOOFFURS_DOG_H
