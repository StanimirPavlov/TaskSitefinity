# TaskSitefinity

User: admin@dmin.com
Password: Tele2105

Create a simple site resembling Zamunda.net using Sitefinity

1. It will consist of three pages. The first page (“Home”) should have:

  • Navigation (only “Home” page is shown in the navigation when not logged in)
  • Login
  • List of news
  • Some poll (simple form)

  Result: Works as expected
  Resources: 
            https://www.youtube.com/watch?v=A3ZUj9seO0Y&t=2675s
            https://www.youtube.com/watch?v=yUH5qx1dXe4
            https://www.youtube.com/watch?v=D6STYzEUALk
            https://www.youtube.com/watch?v=IBmunIR99dk&t=116s
            https://www.progress.com/documentation/sitefinity-cms/overview-page-templates?fbclid=IwAR1pHSU6-zC3Rt7T1GYy2uJbegiQzNPnkeAQF4NMCLGvnxTQ2H78sKDu9gw
            
2. When the user logs in, second page appears on the navigation bar (“Torrents”) which will have:

  • Navigation
  • Simple search
  • List of torrents
  
  Result: Works as expected
  
  Resources:
            https://www.youtube.com/watch?v=4eSx0cVI_Ao
            https://www.youtube.com/watch?v=BYtRhBhl3Z8
            https://www.progress.com/documentation/sitefinity-cms/for-developers-dynamic-modules
            
3. When you click on a torrent it opens a page showing its details, ordered as follows:

  • Title
  • Link for downloading the file
  • Image of the torrent
  • Description
  • Additional info
  • Genre
  • Date created
  
   Result: Works as expected
   
   Resources:
             https://www.progress.com/documentation/sitefinity-cms/overview-widget-templates-mvc
             https://www.youtube.com/watch?v=G7Oy9Lz0VLo
 
 4. The third page (“Add Torrent”) should be visible for logged in users that have the role of 
    “Moderator (torrents)”. The page should have a custom MVC widget that allows the user to create a torrent.
    
    Result: The part with page visability for logged users with role “Moderator (torrents)” - works as expected.
    I created a custom MVC widget but I faced an issue that I could not resolved. When I click the "Save" button
    on Add Torrent page, I hit the breakpoint into the Index method/AddTorrent Controller.
    
    Resources:
              https://www.youtube.com/watch?v=DO5Vu-2PF-w
              https://www.youtube.com/watch?v=l8C7VXZv60s
              https://www.progress.com/documentation/sitefinity-cms/authentication-and-identity-management-api
              https://www.youtube.com/watch?v=nT8rvdDOA6E
              https://www.progress.com/documentation/sitefinity-cms/insight/track-a-custom-mvc-form-widget
              
 Bonus (Optional): Make the torrent available in English and in Bulgarian:
  
    Result: Works as expected
   
    Resources:
              https://www.youtube.com/watch?v=ld70WDnQldM&t=5s
              https://www.progress.com/documentation/sitefinity-cms/translate-content-items-and-taxonomies
              
    
  
  


