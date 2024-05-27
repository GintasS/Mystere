<div align="center">
  <h2>Mystere</h2>
</div>

## Jump to...

  - [Intro](#intro)
  - [Features](#features)
  - [Technologies](#technologies)
  - [Planned Features](#PlannedFeatures)
  - [Round System](#RoundSystem)
  - [Media](#media)

## <a name="Intro"></a>Intro

<p>Mystere is a first-person 3D puzzle survival game that integrates detective elements, developed as a final bachelor thesis project. 
The game aims to blend multiple genres, including first-person shooter, detective, and puzzle elements, into a cohesive and engaging experience.
</p>

## <a name="Features"></a>Features
<ul>
  <li><b>Great graphics:</b> this project was done via HDRP.</li>
  <li><b>Exploration:</b> this is not a small map by any means, so you could take some time to explore it and feel it!</li>
  <li><b>Sound:</b> this game has both UI, environment, enemy and player sounds, and more!</li>
  <li><b>Particle effects:</b> this game features some particle systems, like vent smoke, weapon fire, or fog.</li>
  <li><b>Animations:</b> both the player and zombies have animations, e.g., attacking, running, or reloading a weapon. </li>
  <li><b>Multiple Scenes:</b> The game features a few scenes, from the main scene, to the main menu, pause menu, or game over menu. </li>
  <li><b>Round System:</b> Mystere features a round system: every round you get a random number of zombies, and you must kill them to proceed to the next round.</li>
  <li><b>Shop System:</b> You can buy various items, from ammo to utilities, that will help you survive!</li>
  <li><b>Zombie Stuck System:</b> this prevents a zombie from being stuck right at his spawn point, so a player would not wander around looking for it or restart the game.</li>
  <li><b>Story:</b>The game has implemented a storyline through the dialogue system.</li> 
  <li><b>Multiple weapons:</b> you can select from 6 different weapons, full with sounds and different characteristics: range, damage dealt, ammunition and etc.</li> 
  <li><b>Enemy types:</b> In total, there are 4 enemy types: zombie, dog, insectoid, monster-scavenger.</li>
</ul>

## <a name="Technologies"></a>Technologies 

| Technology Stack | Description |
| ---------------- | ----------- |
| **C#/.NET** | Interacting with Unity's Scripting API is done using the C# programming language. |
| **Unity** | The entire implementation is carried out with the widely-used game engine Unity, which facilitates the manipulation of code, 3D assets, sounds, animations, and particle effects. |
| **A Pathfinding Project** | In order to fully integrate the A* search algorithm, the A* Pathfinding library was used. |
| **Unity Libraries** | Multiple Unity assets were utilized. <br> - FirstPersonCharacter: for controlling the player movement. <br> - MonsterLove.StateMachine: to manage all the different states for the enemies. <br> - Dialogue System: integrating dialogue sequences and searchable objects. |
| **GitHub** | Due to my extensive familiarity with the GitHub system, it was chosen for version control. |
| **The High Definition Render Pipeline (HDRP)** | For a better user experience, and to make the whole experience immersive, as well as to try a new approach to building Unity games, I’ve used HDRP for rendering graphics. |
| **Direct X** | To simulate physics, such as raycasts or friction, Direct X was chosen. |
| **Local Registry** | To store information across game sessions, I utilized the computer's local registry by accessing it through the PlayerPrefs mechanism in Unity. |

## <a name="ClassDiagram"></a>Class Diagram

Some view into the class structure of the Game.

<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/ClassDiagram2.jpg">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/ClassDiagram2.PNG" height="400" style="max-width:100%;"></img>
</a>
<blockquote>Class structure</blockquote>


## High Definition Render Pipeline (HDRP)

The High Definition Render Pipeline (HDRP) [9] technology is an innovative approach in the realm of graphics and visual fidelity within Unity game development. Serving as an advanced rendering framework, HDRP allows game creators to push what’s possible when it comes to realism and visual richness.

At its core, HDRP embraces physically-based rendering (PBR), a cutting-edge strategy that ensures things in the virtual world behave authentically, mimicking the way light interacts with them in reality. This results in surfaces that gleam realistically like metal, feel tactilely like wood, and respond dynamically to environmental lighting.

In essence, HDRP is a comprehensive toolkit for those seeking to push the boundaries of visual excellence in Unity game development. By seamlessly integrating high-definition textures, advanced lighting techniques, and an array of visual effects, HDRP opens a gateway to creating immersive, lifelike worlds that captivate players and bring virtual environments closer to reality than ever before.


## <a name="PlannedFeatures"></a>Planned Features
<p>This is a list of features that I planned to implement, but due to various factors, such as time, I could not.</p>
<ul>
  <li>Inventory and Loot system</li>
  <li>Player throwables(grenades, mines and etc.)</li>
  <li>Interactable environment</li>
  <li>Killstreak/scorestreak system</li>
  <li>Different types of zombies</li>
</ul>

## <a name="RoundSystem"></a>Round System

The round `ZombieRoundHandler` is the central component of the game. The circular system is precisely what its name suggests. Similar to boxing, in this game, the player battles an ever-increasing number of opponents. The idea behind this is to push the player by making the game harder. The least and most foes that can be present in a round are both limited. The round ends when the player eliminates every enemy, and a grace period begins. We use a state system that `MonsterLove` provided. Players use the 30-second grace period to reload on supplies, including ammunition. A new round begins at that point, and new enemies begin to appear. The order of states is this: first, `Round_Start` gets executed, ending with the `Round_End`. Each of those has substates, like `Enter`, `Update` or `Exit`, indicating the start, continuous, and ending phases of these states.

### Round_Start_Enter
It serves as the circular system's cornerstone. In this condition, everything is calculated. What is the anticipated number of enemies and their composition? It will launch the enemy spawning process to introduce adversaries into the game after all of these computations.

### Round_Start_Update
When the round is over, this status is checked. Only when no opponents are actively spawning and every enemy is killed will the round come to a conclusion.

### Round_End_Enter
This state determines the grace period between rounds. The countdown from 30 to 0 is started, giving the player time to be ready for the following round. It also saves data and adds money for every enemy that is eliminated.

### Round_End_Exit
Resets the variables used in the previous round.

## <a name="Media"></a>Media
<p><b>YouTube demo:</b> <a target="_blank" href="https://youtu.be/0TN0fK5Wr5g">Demo</a><br></p>


<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/zombie.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/zombie.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>Spotted a zombie</blockquote>
<br>

<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/player_full_health.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/player_full_health.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>Exploring the map.</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/player_camera.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/player_camera.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>Left image: game view. Right Image: how the camera is represented in the 3D world.</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/audio_sources_map.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/audio_sources_map.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>Audio sources in the game (top view).</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/zombie_attack_circle_top2.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/zombie_attack_circle_top2.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>A visual showing the attack distance of the Zombie enemy class.</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/spawn_points.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/spawn_points.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>The location of all enemy spawn points.</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/appendix_img_4.png">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/appendix_img_4.png" height="400" style="max-width:100%;"></img>
</a>
<blockquote>The implemenetation of the story mode (thanks to Dialogue System).</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/Mystere/blob/master/Images/shop_collider.PNG">
  <img src="https://github.com/GintasS/Mystere/blob/main/Images/shop_collider.PNG" height="400" style="max-width:100%;"></img>
</a>
<blockquote>Shop system.</blockquote>
