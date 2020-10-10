#ifndef SONGS_H_
#define SONGS_H_

#include <string>
#include <vector>
using namespace std;

class Songs
{
private:
    string songName;
    string artistName;
    string albumName;
    string genre;
    int playTime;
    int year;
    int starRating;
    char yesOrNo;
public:

    Songs();
    Songs(string SN, string ArN, string AlN, int PT, int YR, int SR, string GR);
    string getSongName();
    void setSongName(string newSong);
    string getArtistName();
    void setArtistName(string newArtist);
    string getAlbumName();
    void setAlbumName(string newAlbum);
    int getPlayTime();
    void setPlayTime(int newTime);
    int getYear();
    void setYear(int newYear);
    int getStarRating();
    void setStarRating(int newStarRating);
    string getSongGenre();
    void setSongGenre(string newGenre);
    void addSongLibrary(vector<Songs> *library, vector<Songs> *playlist);
};

#endif
