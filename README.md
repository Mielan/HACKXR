# Inspiration
We want to create an outlet for stress. Playing drums is an emotion immersion at a (picturesque) underseas ambience. The futuristic yet simplistic setting design helps dispel extraneous negativities and indulge in convivial music.

# What it does
Our 

# How we built it
We built backend through:
We used Unity to build the project. We built a scene and added game objects to the scene. We attached scripts to the game objects to make them interact with the users. We connected HTC Vive with Unity to interact it. We have 3 main scripts. The first one count score and fail times to determine the won and lose for the player. The second one generates random circles for the player to hit. The third one track collisions. We also have minor scripts to manage the audio sources, text objects, and player movements. 

We built our front end though mostly 3D modling from Maya and light effects and textures from Unity. 

# Challenges we ran into
Making our first VR application is extremely challenging. WMost of us were unfamiliar with creating a project with c# and Unity, and testing applications with VR Headset is defenitely exciting but hard. In the beginning of the 
The circle spawning process challenges us to be clear with the relationship between spawner and the spawned stuff.
We used a prefab for beat circles that will generate the instance of blue circles to mimic the beats. We also need to figure out how to check if the user scores. To determine the effective hit, we check the distance of collision point of sticks and the spawned blue circles with the place of the drum However, we need to pass in the drum reference to each spawned circles. So we create the list of drum references by using the feature of Unity. We also go great lengths to fix our game logics to initialize and destroy the circle correctly.
# Accomplishments that we're proud of

# What we learned

# What's next
