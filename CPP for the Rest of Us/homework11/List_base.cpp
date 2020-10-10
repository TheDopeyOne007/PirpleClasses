#include "List_base.h"

void List_base::printList(vector<string> items, string menu) {
    // this is for displaying the menus for track or playlist
    printf("Select %s #:\n\n", menu.c_str());
    for(int i = 0; i < items.size(); i++) {
        // loops and displays the ordered list of playlists/tracks
        printf("%d - %s\n", i+1, items.at(i).c_str());
    }
}

int List_base::getSize(vector<string> input) {
    // just returns the size of the vector
    return input.size();
}

void List_base::addToPlaylistList(string fileName) {
    // goes into the index.txt file
    // and adds the name of the name playlist
    // and creates a file with the same name of the playlist but with added
    // extension ".playlist"
    ofstream writer;
    string fileNameWithExt = fileName + playlistExt;
    writer.open(indexFile, ios::app);
    if(writer.is_open()) {
        writer << fileName << endl;
    }
    writer.close();
    writer.open(fileNameWithExt);
    writer.close();
}

void List_base::writeListToFile(vector<string> items) {
    // writes the names of the playlist in the vector
    // to the index file
    ofstream writer;
    writer.open(indexFile.c_str());
    for(int i = 0; i < items.size(); i++) {
        writer << items[i] << endl;
    }
}

void Playlist::readIndexFile() {
    // this function will read the index file for all the names of the playlist
    // and the vector is refreshed
    string line; // Create variable string to hold each line in text file
    ifstream reader;
    playListNames.clear();
    reader.open(indexFile.c_str()); // Open File
    while(getline(reader, line)) { // Get every line in file...
        if(!line.empty()) {
            playListNames.push_back(line); // ...and then push in vector playListNames
        }
    }
    // before we write to the file we will sort the vector of playlistNames
    sort(playListNames.begin(), playListNames.end());
    // then we can write to the index.txt
    writeListToFile(playListNames);
    reader.close(); // Close File
}

void Playlist::playlistMenu() {
    //  displays the choices for the user
    cout << "Main Menu\n\n";
    cout << "c. Create a playlist\n";
    cout << "x. Exit program\n\n";
    // if the playlistNames vector isn't empty,
    // we will display the contents
    if(getSize(playListNames) > 0) {
        printList(playListNames, "Playlist");
    }
}

bool Playlist::checkPlaylistDuplicates(string fileName, string input) {
    // checks the vector playListNames if there are duplicates, using
    // the find function from the algorithm library
    if(find(playListNames.begin(), playListNames.end(), input) !=  playListNames.end()) {
        return true;
    }
    return false;
}

void Playlist::deletePlaylist(string input) {
    // deletes the playlistName from the vector playListName
    vector<string>::iterator result = playListNames.begin();
    while(result != playListNames.end()) {
        if(*result == input) {
            result = playListNames.erase(result);
        } else {
            result++;
        }
    }
}

void ListIndex::trackMenu(string playList) {
    // reads the file of the playlist and gets all the tracks from it
    // saves it to the trackNames vector
    readFromTrackFile(playList);
    printf("Playlist '%s' Menu:\n\n", playList.c_str());
    cout << "a. Add track(s) to playlist\n";
    cout << "d. Delete this playlist\n";
    cout << "x. Exit to main menu\n\n";
    // if the trackNames vector isn't empty
    // then we display it's contents
    if(getSize(trackNames) > 0) {
        printList(trackNames, "Track");
    }
}

void ListIndex::readFromTrackFile(string fileName) {
    string line; // Create variable string to hold each line in text file
    ifstream reader;
    // clear the vector to get tracks of a new playList
    trackNames.clear();
    fileName = fileName + playlistExt;
    reader.open(fileName.c_str()); // Open File
    while(getline(reader, line)) { // Get every line in file...
        if(!line.empty()) {
            trackNames.push_back(line); // ...and then push in vector trackNames
        }
    }
    // we will sort the trackNames vector
    sort(trackNames.begin(), trackNames.end());
    reader.close(); // Close File
}

void ListIndex::writeToTrackFile(string fileName, string track) {
    // writes the vector of trackNames to the
    // current playlist file
    ofstream writer;
    // add the play list extension, so we can open it and
    // append into it the name of the playList
    string fileNameWithExt = fileName + playlistExt;
    writer.open(fileNameWithExt, ios::app);
    if(writer.is_open()) {
        writer << track << endl;
    }
    writer.close();
}

bool ListIndex::checkTrackDuplicates(string fileName, string input) {
    // checks if there are duplicates, similar to the duplicate checker in playList
    if(find(trackNames.begin(), trackNames.end(), input) !=  trackNames.end()) {
        return true;
    }
    return false;
}

void ListIndex::deleteTrack(string input) {
    // deletes the track from the vector trackNames
    vector<string>::iterator result = trackNames.begin();
    while(result != trackNames.end()) {
        if(*result == input) {
            result = trackNames.erase(result);
        } else {
            result++;
        }
    }
}

void ListIndex::eachTracksMenu(string playList, string track) {
    // displays the menu for each track
    printf("Playlist '%s'\n", playList.c_str());
    printf("Track '%s' menu:\n\n", track.c_str());
    cout << "d. Delete this track\n";
    cout << "x. Exit to playlist menu\n\n";
}

void ListIndex::writeTrackListTofile(string fileName, vector<string> items) {
    // this is where we can write the tracks into the assigned play list file
    fileName = fileName + playlistExt;
    ofstream writer;
    writer.open(fileName.c_str());
    for(int i = 0; i < items.size(); i++) {
        writer << items[i] << endl;
    }
}
