// Started on: Oct. 2, 2020
// Finsihed on: Oct. 9, 2020

// This project was so far the hardest I have done in any course for C++ and I have learned a
// lot and I still need to learn how to write cleaner code but I will do
// my best to explain everything and will continue to improve. Spent many hours on this, but
// I believe it was worth it, so thank you so much for this platform.

// NOTE: Check the comments in the clear function because I will explain
// why I made the clear that way and I have a lot to learn in C++ so
// I hope I can still pass, that was my one worry since I coudln't
// figure out how to use system clear and read it isn't a really good practice.

// Added some playlist files to test, and added tracks to each, but you can always delete them.

// So first off, I made a MyMainClass class that becomes the center of all the other classes
// and functions to work together to create this project. So check the MyMainClass.cpp.

#include <iostream>
#include "MyMainClass.h"

int main() {
	MyMainClass mainClass;
	mainClass.run();
	return 0;
}
