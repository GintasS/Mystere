<div align="center">
  <h2>Mystere</h2>
</div>

## Jump to...

  - [Intro](#intro)
  - [Features](#features)
  - [Planned Features](#PlannedFeatures)
  - [Third-party Assets](#ThirdPartyAssets)
  - [Round System](#RoundSystem)
  - [Economy Overview](#EconomyOverview)
  - [Media](#media)
  - [Changelog](#changelog)

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
</ul>

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
<p>Before every round, the round system generates a random number between increasing min and max ranges.<br>
That number is going to be total zombies that will spawn for that particular round.<br><br>
E.g. for round number 1, you can expect between 5 and 10 zombies.<br>
    For round number 10, you can expect between 23 and 55 zombies.
</p>

<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Graph2.JPG">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Graph2.JPG" height="300" style="max-width:100%;"></img>
</a>

## <a name="EconomyOverview"></a>Economy Overview
<p>This game has currency to buy items at the shop.<br>
  You gain 200 credits for every zombie killed. Later you can increase this amount by purchasing a special utility item.<br>
 
 <p>Available items:</p>
 <table style="width:30%">
  <tr>
    <th>Item Name</th>
    <th>Item Cost</th>
    <th>Item Description</th>
  </tr>
  <tr>
    <td>1 Ammo Clip (Assault Rifle)</td>
    <td>500</td>
    <td>Single juicy ammo clip for your assault rifle needs!</td>
  </tr>
  <tr>
    <td>3 Ammo Clips (Assault Rifle)</td>
    <td>1400</td>
    <td>Three is better than one. Use your assault rifle and kill' them!</td>
  </tr>
  <tr>
    <td>5 Ammo Clips (Assault Rifle)</td>
    <td>2700</td>
    <td>Ultimate ammo box for your assault rifle.</td>
  </tr>
  <tr>
    <td>1 Ammo Clip (Pistol)</td>
    <td>200</td>
    <td>The old and lonely single ammo clip for your pistol.</td>
  </tr>
  <tr>
    <td>3 Ammo Clips (Pistol)</td>
    <td>800</td>
    <td>The best bang for the buck! Buy it now white it lasts!</td>
  </tr>
  <tr>
    <td>5 Ammo Clips (Pistol)</td>
    <td>1400</td>
    <td>You will kill all the zombies with this bag of 5 ammo clips for your pistol.</td>
  </tr>
  <tr>
    <td><b>Shop Radar</b></td>
    <td><b>0</b></td>
    <td>Displays a distance to the nearest shop. <b>Yay, you already have it!</b></td>
  </tr>
  <tr>
    <td>Zombie Counter</td>
    <td>10000</td>
    <td>Allows you to see how many zombies are currently alive in this round.</td>
  </tr>
  <tr>
    <td>Scrooge McDuck</td>
    <td>14200</td>
    <td>Increases the money given per every zombie killed.</td>
  </tr>
  <tr>
    <td>Health Regeneration</td>
    <td>18900</td>
    <td>Makes a player nearly invincible(sort of). Regenerate health every X seconds.</td>
  </tr>   
</table>

<p><center><b>Zombie kills needed to buy a specific item</b></center></p>

<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Graph4.JPG">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Graph4.JPG" height="300" style="max-width:100%;"></img>
</a>

## <a name="Media"></a>Media
<p><b>YouTube demo:</b></p>

<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%201.jpg">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%201.jpg" height="300" style="max-width:100%;"></img>
</a>
<blockquote>Looking into a door</blockquote>
<br>
<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%202.jpg">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%202.jpg" height="300" style="max-width:100%;"></img>
</a>
<blockquote>Spotted a zombie</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%203.jpg">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%203.jpg" height="300" style="max-width:100%;"></img>
</a>
<blockquote>Shooting a zombie</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%204.jpg">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%204.jpg" height="300" style="max-width:100%;"></img>
</a>
<blockquote>Shop Menu</blockquote>

<br>
<a target="_blank" href="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%205.jpg">
  <img src="https://github.com/GintasS/The-Living-Dead/blob/master/Images/Game%205.jpg" height="300" style="max-width:100%;"></img>
</a>
<blockquote>Pistol</blockquote>
