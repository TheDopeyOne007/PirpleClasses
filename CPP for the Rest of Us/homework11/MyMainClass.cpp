#include "MyMainClass.h"

// The run function starts everything when the program starts
void MyMainClass::run() {
    // We decalre the following variables
    string artist, title, playlistName, trackName;
    string playListSelect, trackSelect;
    char mainChoice = ' ';
    int playlistIndex, trackIndex;
    // We instantiate the objects, each object's class
    // will be explained in its own file
    TrackParser trackParser;
    Playlist playlist;
    List_base listBase;
    ListIndex listIndex;

    // This while loop starts off the main menu, so as long
    // as the first choice/main choice isn't x, the whole menu will
    // continue to function.
    while(mainChoice != 'x') {
        string choice;
        char secondChoice = ' ';
        // We display the playlist menu
        playlist.readIndexFile();
        playlist.playlistMenu();
        // Get the choice
        cout << "\nYour choice: ";
        cin >> choice;
        if(choice.length() > 1) {
            clearScreen();
            cout << "Invalid Option. Try Again.\n\n";
            continue;
        }
        mainChoice = choice.at(0);
        // Calculate the playlist index in its vector
        // based on the mainChoice converted to an int by subtracting by
        // 48 but subtracted by 49 to count for 0 based index
        playlistIndex = mainChoice - 49;
        cin.ignore();
        // If mainChoice is 'c' then the user can create a playlist
        // which will be saved in the vector for playlists in the object
        if(mainChoice == 'c') {
            cout << "\nPlease enter a name for your playlist: ";
            getline(cin, playlistName);
            clearScreen();
            // checks if the playlist has already been made
            if(playlistName.length() == 0) {
                cout << "Sorry. That Playlist name can't be empty.\n\n";
                continue;
            }
            if(playlist.checkPlaylistDuplicates(listBase.indexFile, playlistName)) {
                cout << "Sorry. That Playlist already exists. Please try again.\n\n";
                continue;
            }
            // adds the new playlistName is saved to  a file
            listBase.addToPlaylistList(playlistName);
            continue;
        } else if(mainChoice == 'x') {
            // ends the main menu
            break;
        } else if(playlistIndex >= listBase.getSize(playlist.playListNames) || mainChoice == '0') {
            // checks if the playlistIndex is valid, if not it will display the menu again
            clearScreen();
            cout << "Playlist number not found.\n\n";
            continue;
        }
        // clear screens for the second menu, if the playlistIndex in the vector
        clearScreen();
        while(secondChoice != 'x') {
            // declare a string to hold the string value of users song entered
            string song;
            char thirdChoice = ' ';
            // this saves the name of the current playlist selected
            playListSelect = playlist.playListNames.at(playlistIndex);
            listIndex.trackMenu(playListSelect);
            cout << "\nYour choice: ";
            cin >> choice;
            if(choice.length() > 1) {
                clearScreen();
                cout << "Invalid Option. Try Again.\n\n";
                continue;
            }
            secondChoice = choice.at(0);
            // ignores all inputs after the char until new line, just in case user enters string
            trackIndex = secondChoice - 49;
            // if secondChoice is 'a' the user can add as many songs until the user enters 'x'
            // it will check if there is a track with the same name as what the user entered, and
            // follow the track parser rules to only accept certain strings and must have artist and title
            if(secondChoice == 'a') {
                cin.ignore();
                while(true) {
                    listIndex.readFromTrackFile(playListSelect);
                    cout << "Enter a title and artist, or 'x' to exit:\n";
                    getline(cin, song);
                    // based on the function I wrote, it returns to a tuple of two strings
                    // and I save those into two separate variables, artist and title
                    tie(artist, title) = trackParser.parser(song);
                    if(song == "x") {
                        clearScreen();
                        break;
                    }
                    if(song.length() == 0) {
                        cout << "No text entered. Please try again.\n";
                        continue;
                    }
                    // If the length of the song isn't 0, and it follows the rules of parsing
                    // then we can rewrite the song into the <artist>: <title>
                    song = artist + ": " + title;
                    // we check again just to be sure that neither the artist or title are empty strings
                    if(artist.length() == 0 || title.length() == 0) {
                        cout << "Unrecognized format. Please try again.\n";
                        continue;
                    }
                    // we check if there are any duplicates of the song entered
                    if(listIndex.checkTrackDuplicates(playListSelect, song)) {
                        cout << "Sorry. That Track already exists. Please try again.\n\n";
                        continue;
                    }
                    // if it passes through everything, we can write to the file the track which can be read
                    // later on
                    listIndex.writeToTrackFile(playListSelect, song);
                }
                continue;
            } else if(secondChoice == 'd') {
                // this deletes the playlist from the vector if 'd' is selected, and rewrites the file
                // with the new vector without the deleted playlist
                playlist.deletePlaylist(playListSelect);
                listBase.writeListToFile(playlist.playListNames);
                clearScreen();
                cout << "Playlist Deleted\n\n";
                break;
            } else if(secondChoice == 'x') {
                // exists the second menu and goes to the first menu avoiding the third menu for each track
                clearScreen();
                break;
            } else if(trackIndex >= listBase.getSize(listIndex.trackNames) || trackIndex < 0) {
                // same for playlist, it will check the trackIndex in a different vector
                // and if the choice isnt any of the options or a valid track number
                // it will display a message that track number is not found
                clearScreen();
                cout << "Track Number not found.\n\n";
                continue;
            }
            // once the trackIndex is valid and we move to the second menu, we
            // will get the trackName based on the trackIndex in the vector trackNames
            trackName = listIndex.trackNames.at(trackIndex);
            clearScreen();
            while(thirdChoice != 'x') {
                listIndex.eachTracksMenu(playListSelect, trackName);
                cout << "\nYour choice: ";
                cin >> choice;
                if(choice.length() > 1) {
                    clearScreen();
                    cout << "Invalid Option. Try Again.\n\n";
                    continue;
                }
                thirdChoice = choice.at(0);
                if(thirdChoice == 'd') {
                    // this deletes the track from the vector and then rewrites the vector into
                    // the current playlists file
                    listIndex.deleteTrack(trackName);
                    listIndex.writeTrackListTofile(playListSelect, listIndex.trackNames);
                    clearScreen();
                    cout << "Track Deleted\n\n";
                    break;
                } else if(thirdChoice == 'x') {
                    // this exists the menu for each track and goes back to the second menu
                    clearScreen();
                    break;
                } else {
                    // if it isnt valid, stay on the current menu and wait till it is 'x'
                    clearScreen();
                    cout << "Invalid Option. Try again.\n\n";
                }
            }
        }
    }
    farewell();
}

void MyMainClass::farewell() {
    cout << "Farewell user...\n";
}

void MyMainClass::clearScreen() {
//    Since I am using Mac OS, I couldn't use the system clear function
// and have found no solution to this, so I hope for your understanding,
// but for now i just print the following lines to space out in between
// but I will leave the comment of the possible ways to clear the screen
// if I were to use Windows. I also don't want to implement functions
// that won't work across all platforms, so for now, I will stick with this
// to indicate the clear is called here. Hoping for your understanding, will
// continue to dive deep into this case and learn more.
    cout << "----------------------------------------\n";
    cout << "                                        \n";
    cout << "               Clear Screen             \n";
    cout << "                                        \n";
    cout << "----------------------------------------\n";
//    This one uses the header files term.h and unistd.h, I
// found this solution on cplusplus.com, it requires you to add -lncurses
// after g++ <filename>.cpp, so it would be g++ main.cpp -lncurses
//    if (!cur_term)
//    {
//        int result;
//        setupterm( NULL, STDOUT_FILENO, &result );
//        if (result <= 0) return;
//    }
//    putp( tigetstr( "clear" ) );

//    This one prints out an ascii character that would clear screen,but
// it doesn't work for all terminals
//    cout << "\033[2J\033[1;1H";

// I will do more research and would possibly purchase a windows laptop
// to study other OS systems for other cases such as this.
}
