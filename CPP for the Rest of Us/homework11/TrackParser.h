#ifndef HOMEWORK11_TRACKPARSER_H
#define HOMEWORK11_TRACKPARSER_H
#include <iostream>
#include <string>
#include <vector>

using namespace std;

class TrackParser {
public:
    // only holds the function trim to remove whitespaces before and after a string
    // and a parser which I made to return a tuple of two strings
    string trim(string str, const string& whitespaces = "\t\n\v\f\r ");
    tuple<string, string> parser(const string& song);
private:
    const string by = " by ";
    const string hyphen = "-";
    const string colon = ":";
};

#endif //HOMEWORK11_TRACKPARSER_H
