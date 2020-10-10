#include "TrackParser.h"

string TrackParser::trim(string str, const string &whitespaces) {
    str.erase(0, str.find_first_not_of(whitespaces));
    str.erase(str.find_last_not_of(whitespaces) + 1);
    return str;
}

tuple<string, string> TrackParser::parser(const string& song) {
    string artist, title, ret;
    int position;
    if(song.length() == 0) {
        return make_tuple(" ", " ");
    }
    if(song.find(colon) != -1) {
        position = song.find(colon);
        artist = song.substr(0, position);
        title = song.substr(position+1, song.length() - position);
    } else if(song.find(hyphen) != -1) {
        position = song.find(hyphen);
        artist = song.substr(position+1, song.length() - position);
        title = song.substr(0, position);
    } else if(song.find(by) != -1) {
        position = song.find(by);
        artist = song.substr(position + by.length(), song.length() - position);
        title = song.substr(0, position);
    }
    return make_tuple(trim(artist), trim(title));
}


