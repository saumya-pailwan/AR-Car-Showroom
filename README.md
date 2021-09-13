# Eminent Cars: AR-Car-Showroom

### Problem Definition: 
In this project, I’ve used AR technology from Vuforia, the Unity game engine, combining with voice-controlled, cloud-based artificial intelligence to build fully functional car showroom application. Users can see the different types of cars available in a showroom with all the features without being physically present over there
A complete 3D model of a car can be placed in front of the buyer and they can check all features just by a few clicks. Also, the customers can give commands using the record button, making the app much more interactive.

### Technologies Used:
- Unity
- Vuforia
- WitAI
- Android

### System Functionality:

#### 1. Intro Scene
![car1](https://user-images.githubusercontent.com/59173499/133079376-3cce3c75-5437-4266-bf0e-b2c13c0e07a2.png)
- It showcases all cars
- We can toggle between them
- Select the car of choice

#### 2. Main Scene
![car2](https://user-images.githubusercontent.com/59173499/133079795-4630fe98-5e13-41fa-87b0-2b386eee6bea.png)
- Project the 3D car model in real world
- Try out different features
- Interact by voice commands

### WorkFlow:

Audio Input ----> Sending audio to cloud ----> Speech to text conversion ----> Identify entities ----> Output to Unity -----> Firing the correct model

### Animators & Triggers:
#### 1. Open & Close commands
- Door
- Windows
- Hood
- Trunk
#### 2. Changing Colour
#### 3. Starting/Stopping the engine

### Codes:
#### 1. Introduction Scene:
Rotation, Car Selection,Information Panel
#### 2. Main Scene:
Game controller, Handle, Colour Switcher, Car controller, Wit 3D, SavWav, Side panel, Swap Car

