# Flappy Bird Game in Unity

A 2D Flappy Bird-style game developed in Unity 2022.3.62f3. Navigate a bird through moving obstacles by flapping to gain height and avoid collisions.

## 🎮 Gameplay

- **Objective**: Guide the bird through gaps in moving bricks/pipes
- **Controls**: 
  - Press `SPACE` or `LEFT MOUSE BUTTON` to flap
- **Scoring**: Pass through each brick pair to increase your score
- **Game Over**: Collision with bricks or boundaries ends the game

## 📋 Features

- Smooth flapping mechanics with physics-based movement
- Procedurally spawned obstacles with random vertical positioning
- Real-time score tracking
- Bird animation with collision detection
- Responsive controls
- Scene reload on game over with brief slow-motion effect

## 🏗️ Project Structure

```
Assets/
├── _Scripts/
│   ├── Bird.cs              
│   ├── Bricks.cs            
│   └── BricksSpawner.cs     
├── Animations/
│   ├── Bird_Hit.anim        
│   ├── Flying_Bird.anim     
│   └── GreenFlappyBird_0.controller  
├── Prefabs/
│   └── Brickpair.prefab     
├── Scenes/
│   └── Play.unity           
├── Sprites/                 
└── Settings/
```
                

## 🔧 Core Components

### Bird.cs
Controls the player's bird character:
- **Flapping**: Applies upward force with configurable strength
- **Rotation**: Bird tilts based on velocity
- **Collision Detection**: Triggers game over on impact
- **Scoring**: Increments score when passing obstacles
- **Max Height Limit**: Prevents bird from flying too high

**Key Settings:**
- `_flapForce`: 8f (upward impulse strength)
- `_rotation`: 1.5f (tilt sensitivity)
- `_maxHeight`: 4f (maximum flying height)

### Bricks.cs
Manages individual obstacle behavior:
- Moves obstacles from right to left at constant speed
- Automatically destroys after lifecycle timeout
- **Speed**: 3f (pixels per second)
- **Lifecycle**: 12f seconds

### BricksSpawner.cs
Spawns brick pairs at regular intervals:
- **Spawn Interval**: 3f seconds
- **Vertical Range**: -1.5f to 0.8f (randomized gap position)
- Immediate spawn on game start
- Gizmo visualization for spawn range in editor

## 🎨 Animations

- **Flying_Bird**: Idle flying state animation
- **Bird_Hit**: Collision impact animation
- Smooth transitions between animation states

## 🚀 Getting Started

### Requirements
- Unity 2022.3.62f3 or later
- 2D rendering pipeline configured
- TextMeshPro package (included)

### Installation
1. Clone the repository
2. Open the project in Unity
3. Navigate to Assets/Scenes/Play.unity
4. Press Play in the editor

### Building
Build the game through Unity's Build Settings:
- File → Build Settings
- Select target platform
- Click Build

## 🎯 Game Settings

All key parameters are exposed in the Unity Inspector for easy tuning:

| Component | Parameter | Default |
|-----------|-----------|---------|
| Bird | Flap Force | 8f |
| Bird | Max Height | 4f |
| Bird | Rotation Sensitivity | 1.5f |
| Bricks | Move Speed | 3f |
| Bricks | Lifecycle | 12f |
| BricksSpawner | Spawn Interval | 3f |
| BricksSpawner | Min Y Position | -1.5f |
| BricksSpawner | Max Y Position | 0.8f |

## 🎨 Sprites & Assets

- **GreenFlappyBird.png**: Main bird sprite
- **BirdHit.png**: Collision sprite variant
- **brick_3.png**: Obstacle sprite
- **Full-Background.png**: Game background
- **Tile.png**: Tileable environment texture

## 📱 UI

- **Score Display**: Real-time score using TextMeshPro
- Located in the top corner of the gameplay area
- Updates instantly when bird passes obstacles

## 🐛 Known Features & Behavior

- Game briefly slows down (0.1x speed) when collision occurs before reload
- Bird has maximum height limit to maintain gameplay challenge
- Score persists only during a single play session (resets on game over)
- Obstacles spawn immediately at game start for immediate challenge

## 🔄 Game Loop

1. Bird spawns at starting position
2. Obstacles spawn at 3-second intervals with random vertical gaps
3. Player flaps to navigate through gaps
4. Score increases on successful gap passage
5. Collision triggers game over animation and scene reload
6. Scene resets for next attempt

## 🤝 Development Notes

- Uses Physics2D for realistic movement
- Rigidbody2D for collision detection
- Animator for smooth sprite animations
- Scene Manager for restarts
- Time scaling for dramatic collision effect

## 📦 Dependencies

- Unity 2022.3.62f3
- TextMeshPro (included with Unity)
- 2D Physics System
- Universal Render Pipeline (configured in ProjectSettings)

## 📄 License

This is a learning/hobby project. Feel free to modify and extend as needed.

**Engine**: Unity 2022.3.62f3  
**Platform**: Windows/Cross-platform



"The beautiful thing about learning is that nobody can take it away from you." - B.B. King
