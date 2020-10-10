# original varaibles
# song_title = "One Day" # name of song
# artist = "Matisyahu" # name of artist
# featured_artist = "Akon" # name of featured artist
# album_name = "Light" # album name
# genre = "Reggae" # genre of the song
# year = 2008 # year is was released
# record_label = "Epic" # name of record label 
# views_by_millions = 75.46 # float to hold the views on yt vid by millions

# dictionary of the variables as key with the value as values 
fave_song = {"song_title": "One Day", "artist": "Matisyahu", "featured_artist": "Akon",
"album_name": "Light", "genre": "Reggae", "year": 2008, "record_label": "Epic", "views_by_millions": 75.46}

# function guess to return true if the user enters the right key and right value
def guess(k, v):
    if k in fave_song and v == fave_song[k]:
        return True
    return False

for key in fave_song:
    print(key, fave_song[key])

# Some test cases
print(guess("year", 2008)) # Output = True
print(guess("year", 2009)) # Output = False
print(guess("Year", 2008)) # Output = False
print(guess("song_title", "One Day")) # Output = True
