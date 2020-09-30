Intro to CSS

# What is CSS?
- Cascading Style Sheets - language to style and lay out web pages
- Can use to style font, colour, spacing, layout of page, animations
- Language for styling your document and determining how it is presented

# How can we alter the appearance of HTML and CSS?
- Web browser looks for CSS rules
    # What's a CSS rule?
    - Selectors - essentially selects the HTML element(s) you want to style
    - Properties - properties which you want to change

# CSS Declarations
- Where you set the CSS properties to specific values

some-element {
    property-1: value;
    propert-2: value;
    background-color: rgb(0, 0, 255);
}

# The CSS Box Model
- Each element in the HTML document can be thought of as a rectangle box
- The standard box model describes the space an element takes up
- Each box has four edges: margin, border, padding, content edges

# CSS Specificity 
- Specificity is very important in CSS
    0. Type selectors (e.g. h1, div, header)
    1. Class selectors (e.g. .<name_of_class>)
    2. ID selectors (e.g. #<name_of_id>)

