//
// Created by Anthony Heitzeberg on 10/8/20.
//

#ifndef HOMEWORK11_LIST_BASE_H
#define HOMEWORK11_LIST_BASE_H
#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include <algorithm>

using namespace std;

class List_base {
public:
    // this holds the constant string for the name of the
    // file that holds the names of all playlists
    const string indexFile = "index.txt";
    // this is the constant string for the extension
    const string playlistExt = ".playlist";
    // this function adds the name of the playlist to the index file
    void addToPlaylistList(string fileName);
    // this writes the vector of playlistNames into the index file
    void writeListToFile(vector<string> items);
    // this displays the contents of a vector in an ordered list manner, used
    // for tracks and playlist
    void printList(vector<string> items, string menu);
    // this will return the size of the vector
    int getSize(vector<string> input);
};

class Playlist : public List_base {
public:
    // in the playlist, we have the vector of strings for the name of the playlists,
    // that we will read from the file and use to rewrite back into the file
    vector<string> playListNames;
    // this function reads the index file and the file name is inherited from the List_base
    void readIndexFile();
    // this displays the playlist menu
    void playlistMenu();
    // deletes the playlist that is passed into this function
    void deletePlaylist(string input);
    // returns true if there are duplicates
    bool checkPlaylistDuplicates(string fileName, string input);
};

class ListIndex : public List_base{
public:
    vector<string> trackNames;
    // use to rewrite the tracks back into the file
    void writeToTrackFile(string fileName, string track);
    // use to append each playlist into the file, and will be
    // saved into the vector
    void writeTrackListTofile(string fileName, vector<string> items);
    // used to read all the tracks in the current playlist
    void readFromTrackFile(string fileName);
    // displays the playlist menu with the tracks
    void trackMenu(string playList);
    //  displays the menu for each tracks
    void eachTracksMenu(string playList, string track);
    // deletes a track that is passed into this function
    void deleteTrack(string input);
    // returns true if there are duplicates in the track vector
    bool checkTrackDuplicates(string fileName, string input);
};


#endif //HOMEWORK11_LIST_BASE_H
