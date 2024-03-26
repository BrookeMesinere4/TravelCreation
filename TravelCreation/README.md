# Assignment 4: Creating our website design and our APIs 
## Our company's website description:
Page one: The first page will be our home page. On this page, users can get an idea of the features the application has to offer. A search bar is also planned to be incorporated into the site, which will lead you to page two. The design aspect is designed to be modern, allowing users to easily use and have a navigation menu for the other pages. Like the image shown below, the home page will have some resemblance. 

Page two: Our search page, a user-friendly tool, allows users to search for hotels based on their preferred radius and date range (2 APIs included). The search results are conveniently divided into two lists: hotels available within the specified radius and hotels available within the chosen date range. Once a hotel piques their interest, users can click on it to be directed to page three.

Page three: This page provides comprehensive hotel information, giving users a clear picture of their potential stay. Users can also click on a button to access page six to view reviews and ratings for the selected hotel. This feature-rich page ensures users are well-informed before making a booking decision. Room availability details are also provided (2 APIs included).

Page four: This page will list destinations that customers will enjoy staying at. We will devise a list of 5 of our favorite warm destinations and 5 of our favorite cold destinations. This will allow our customers to choose whether to go to colder or warmer places when traveling. 


Page five: This page will be used as our climate page. This will be where users can check the weather of a certain location they plan to travel to.

Page six: On the last page, we will have the customers' ratings of the hotels using a scale of 1-10, 1 being the lowest and 10 being the highest. Customers will also have a section where they can provide a detailed review about their stay and what they thought about that specific hotel they had stayed at. (2 APIs included)

## Procedures
### Trey Zontek
The first stored procedure used was "spHotelGetDetails." We decided to use this procedure in order to get all the information needed on a specific hotel by putting in the hotel ID.

The following procedure used was "spHotelGetRatings." This product gave the user access to hotel ratings by hotel ID.

### Brooke Mesinere
The API "spRoomGetAvailByDate" was made in order to get the available room date. The user can put in the desired date that they want to travel and see if the hotel room is available for stay. I made a code that allows users to put in that desiered date and see if that room is available. This API will tie in with the AvailabilitybyDateRange API. Mine will show if it is available for the first selected date and than the AvailabilitybyDateRange API will allow for the users to see if the range of the dates wanting to stay are available as well. It is important to add this into our website because for any hotel someone wants to stay at it is important for people to see if the hoetl is even available for the desired dates that they want to stay.

The API "spHotelAddReview" was created in order for users who stayed at the hotels to leave a review if they want too. I created a code that allows users to leave a review in a space and write as much as they want too. The code allows for it to return multiple lists. This is crucial for our website because it is always helpful, when looking at hotels to stay at, to see the reviews left. Reviews show if the hotel is clean, nice, dirty, not good to stay at, etc. 
### Ella Southwell
The API "spRoomGetAvailabilityByDateRange" was created to get the availability of dates the user can use if staying multiple nights at a hotel. Using the room availability table, I created a code allowing users to find all available dates during a given period. Then, I group the dates available by the room ID so the user can look at the dates available for a specific hotel. This API is valuable for our site because it helps users book for specific days. The input for this code is the dates the user is looking for. The output is the room available during those dates.

The API "spHotelSearchByRadius" was used to get all hotels within a radius given by a user. This API was created using the hotel table. Then, I created the attributes @longitude, @latitude, and @radius. I then used the distance formula to find the radius. The code then checks for hotels less than or equal to the radius. This procedure helps users find hotels within a particular area and is essential so users can find specific locations. The input is the latitude and longitude the user is looking for. The output is the the hotels in given radius.

## References
We followed our own notes and examples that we got from lectures in this assignment. We also had help from ChatGPT to convert SQL code to APIs. The prompt used in ChatGPT is as followed:
"I'm converting SQL server procedures to APIs in ASP.NET Core 8. I need to convert this table to a class. Give me the code (Followed by sql code for each table)."
