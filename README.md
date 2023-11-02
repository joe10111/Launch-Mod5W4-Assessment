# Week 4 Assessment

In this week's assessment, imagine you have been scheduled for a half-day interview.  The first part of the interview is a technical challenge!  You will have 90 minutes to complete a technical challenge and provide some reflection.

## Technical Challenge (10 points)

### Setup
* Fork and clone this repository.
* Click on 'Planets' in the navbar and make sure you see the 8 planets of our solar system.
* Checkout a new branch and complete the following task.

Your task is to add the explored planets of the galaxy 'Far Far Away' (all of the planets in the star wars films, as outlined in the SWAPI API).

We would like you to get the necessary data by consuming the [SWAPI](https://swapi.dev/) API.  A successful mission will:
* Use HttpClient to make an API call to SWAPI when a request comes in (to get the most up-to-date information!)
* Display the known planets of the Far Far Away Galaxy on a view.
  * Be sure to include the name and population of each planet.

Outside of those requirements, you may choose to add any additional functionality!

When finished, create a PR and include your answers to the reflection questions below in a PR comment.

## Reflection Questions (6 points)
- What about this challenge was most difficult for you?
	- The most difficult aspect of this exam was how I chose to approach it and what resources I had available to pull from. This week's group's mini project didn't go as well as I had hoped and left me with not the most complete or thought out project to pull from for this exam. It left me in a difficult position where my approach to this exam was a different approach than how I did it in the project. My hope was to learn something new and simplify the process. This didn't happen sadly, my approach complicated the project alot. For example the decisions I made for how the planets should be represented in data started off as an emulatable for star wars planets while the milky way planets was a list by default. This created a lot of issues later down the line when I tried to create partial views and compiled the two lists in one view. I tried to fix my mistake but with how I had set up the API call I didn't get my planets to load in the view.
- Highlight one piece of code that you wrote that you are especially proud of.
	- I am proud of how I figured out partial views even if I didn't get my API call to load in the partial view correctly. For example the index.cshtml for planets shows how I was able to implement y partial views. 
- What would you do next, if we gave you another hour?
	- To be honest, walking away from this exam is hard. It's the first exam since the early mods where I wasn't able to complete the base functionality and had to move onto questions. For example If I had another hour I would restart, try a similar approach to how we did it in class and in the mini project and then try to encourage partial views once I had gotten it working. This exam allowed me to check in with myself and see where I need to focus more of my time with studying. My goal moving forward is to review the api lessons and re-do the mini project on my own so I can have a good understanding going into next weeks project

## Rubric

This assessment has a total of 16 points.  Earning 10 or more points is a pass.

For the technical challenge, we are looking for:
* 2 Points - successful creation of a HTTPClient
* 2 Points - correct URL configuration
* 1 point - making a get request
* 2 points - turning the response into a list of planets
* 3 points - getting the requested planets showing up on a page

