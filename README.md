# unity3D-PUN-scalability-in-online-games

Online multiplayer FPS game made with Unity3D game engine and PUN(Photon Unity Networking) package.
Networked virtual environments can have large number of concurrent users and they usually have problems with scalablity.
Those systems are also very sensitive about latency and packet loss in the network.
This game shows some of techniques that are mostly use to achieve scalablity like consistency management, dead reckoning,
interpolation, network culling and world division.

<h3>Matchmaking</h3>
Each player can create a new room or look at list of available rooms and join into one. </br>
Only the master client(room creator) can start the game, scene loading for other players in the same room is automatically synced.

|                                                                  |                                                                  |
| :--------------------------------------------------------------: | :--------------------------------------------------------------: |
| <img  alt="Login" src="./Readme%20Resources/image/login.png"> | <img  alt="Matchmaking Options" src="./Readme%20Resources/image/matchmaking.png"> |
| <img  alt="New Room" src="./Readme%20Resources/image/new_room.png"> | <img  alt="Room Info" src="./Readme%20Resources/image/in_room.png"> |
| <img  alt="Room List" src="./Readme%20Resources/image/room_list.png"> | <img  alt="Loading" src="./Readme%20Resources/image/loading.png"> |

<h3>Combat</h3>

|                                                                  |                                                                  |
| :--------------------------------------------------------------: | :--------------------------------------------------------------: |
| ![Gameplay](Readme%20Resources/gif/combat.gif) | <img  alt="Matchmaking Options" src="./Readme%20Resources/image/respawning.png"> |

<h3>Options</h3>

|                                                                  |                                                                  |
| :--------------------------------------------------------------: | :--------------------------------------------------------------: |
| <img  alt="Pause Menu" src="./Readme%20Resources/image/pause_menu.png"> | <img  alt="Game Options" src="./Readme%20Resources/image/in_game_options.png"> |


## Without interpolation
![Gameplay](Readme%20Resources/gif/without_interpolation.gif)

## With interpolation
![Gameplay](Readme%20Resources/gif/with_interpolation.gif)

## Network simulation, packet loss at 30%
![Gameplay](Readme%20Resources/gif/network_simulation.gif)

## Network simulation, packet loss at 30% + Dead Reckoning
![Gameplay](Readme%20Resources/gif/extrapolation.gif)

<h3>Controls</h3>

|           Input          |     Action    |
|:------------------------:|:-------------:|
| W, A, S, D or Arrow Keys |    Movement   |
|      Mouse Rotation      | Look Rotation |
|        Left Click        |    Shooting   |
|           Space          |    Running    |
|          Escape          |   Pause Menu  |
