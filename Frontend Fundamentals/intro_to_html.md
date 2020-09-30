HTML BASICS

# What is HTML?
- Hypertext Markup Language - standard markup language used to create web pages
- Basically tells your browser how to display webpages

# What does HTML look like?
- HTML uses tags and elements to enclose different parts of the content 
    <p> -> tag </p> -> closing tag
ex. <p>My name is Anthony</p> -> first element
    <p>What's your name?</p> -> second element

e.g.:
<!DOCTYPE html>                     # informs the browser that the document type is html
<html>                              # wraps all content
<head>                              # put content that shouldn't be shown to visitors
                                    #   e.g.: link to style sheets or javascript files
    <meta charset="utf-8"/>         # sets the character set to utf-8
    <title>Your title here</title>  # sets the title of the webpage
</head>                             # closing tag for head
<body>                              # put content that should be shown to visitors
    <p>Hello World.</p>             # paragraph tag with element
</body>                             # closing tag for body
</html>                             # closing tag for html, ends the wrap
