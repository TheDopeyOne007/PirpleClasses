//
// Created by Anthony Heitzeberg on 10/8/20.
//

#ifndef HOMEWORK11_MYMAINCLASS_H
#define HOMEWORK11_MYMAINCLASS_H
#include <iostream>
#include <string>
#include <tuple>
#include <cstdlib>
#include <ctype.h>
//#include <ncurses.h>
//#include <unistd.h>
//#include <term.h>
//#include <curses.h>
#include "List_base.h"
#include "TrackParser.h"

using namespace std;

class MyMainClass {
public:
    void run();
    void farewell();
    void clearScreen();
};


#endif //HOMEWORK11_MYMAINCLASS_H
