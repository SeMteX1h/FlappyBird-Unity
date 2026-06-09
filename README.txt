# Flappy Bird Clone

A simple Flappy Bird clone made with Unity.

## Project Overview

This project was created to practice:

- Unity 2D
- Rigidbody2D Physics
- Collision Detection
- UI System
- Scene Management

## Main Scripts

### BirdScript
Handles:
- Bird movement
- Jump input
- Collision detection
- Game Over trigger

### PipeSpawnerScript
Handles:
- Pipe spawning
- Random pipe height generation

### PipeMoveScript
Handles:
- Pipe movement
- Destroying off-screen pipes

### PipeMiddleScript
Handles:
- Score detection
- Prevents scoring after Game Over

### LogicScript
Handles:
- Score management
- Restart system
- Game Over UI





------------------------------------------

also in PDf

# Flappy Bird - Project Overview

## Project Flow

Player presses Space
↓
BirdScript applies upward velocity
↓
Bird passes between pipes
↓
pipeMiddleScripte adds score
↓
LogicScripte updates UI

If Bird hits pipe/ground
OR leaves screen bounds
↓
BirdScript triggers Game Over
↓
LogicScripte displays Game Over Screen

---

## Script Responsibilities

### BirdScript

Purpose:
Controls the player character.

Responsibilities:

* Detect Space key input
* Apply flap force using Rigidbody2D
* Detect collisions
* Detect leaving screen bounds
* Trigger Game Over
* Disable actions after death

Main Variables:

* flapStrenghth
* BirdIsAlive
* myRigidbody

---

### LogicScripte

Purpose:
Acts as the Game Manager.

Responsibilities:

* Store player score
* Update score UI
* Display Game Over screen
* Restart current scene
* Quit application
* Track game state using gameIsOver

Main Variables:

* PlayerScore
* gameIsOver
* gameOverScreen

---

### PipeSpawnerScript

Purpose:
Creates pipe obstacles.

Responsibilities:

* Spawn first pipe
* Spawn pipes repeatedly
* Generate random pipe heights

Main Variables:

* SpawnRate
* timer
* heightOffset

---

### PipeMoveScripte

Purpose:
Moves obstacles.

Responsibilities:

* Move pipes left
* Destroy pipes after leaving screen

Main Variables:

* PipeMoveSpeed
* deadzone

---

### pipeMiddleScripte

Purpose:
Handles scoring.

Responsibilities:

* Detect bird passing through pipe gap
* Increase score
* Prevent scoring after Game Over

Dependencies:

* LogicScripte

---

## Important Relationships

BirdScript
└── calls → LogicScripte.gameOver()

pipeMiddleScripte
└── calls → LogicScripte.addScore()

LogicScripte
└── controls UI

PipeSpawnerScript
└── creates Pipe Prefabs

PipeMoveScripte
└── destroys old Pipe Prefabs

---

## Known Improvements

Future Version Ideas:

* High Score system
* Sound effects
* TextMeshPro UI
* Pause menu
* Difficulty scaling
* Background themes
* Object Pooling for pipes

---

## Bugs Already Fixed

* Score increasing after Game Over
* Game Over screen visible on startup
* UI scaling issues after Unity upgrade
* Bird gravity tuning
