**Flappy Bird Clone in Unity**
A complete implementation of the classic Flappy Bird game developed with Unity Engine, featuring custom shaders, responsive physics, and clean game architecture. This project was created as part of comprehensive Unity game development learning.

**Project Overview**
This repository contains a fully functional Flappy Bird clone developed through structured learning. Players control a bird navigating through procedurally generated pipe obstacles with smooth gameplay mechanics, visual polish, and score tracking.
Used Features:
**Intuitive Controls:** Single-button gameplay (Spacebar/Mouse Click) for instant accessibility

**Dynamic Obstacles:** Procedurally generated pipes with random height variations

**Score Tracking:** Real-time scoring system with persistent high score tracking

**Visual Polish:** Custom shader effects and smooth animations (83.2% of codebase)

**Game State Management:** Clean state handling (Menu, Playing, Game Over)

**Audio Integration:** Sound effects for actions and background music

**Responsive UI:** Clean interface with score displays and game over screens

**Project Structure**
Flappy-Bird-Game-in-Unity/
├── Assets/                   
│   ├── Scripts/             
│   ├── Shaders/             
│   │   ├── ShaderLab files  
│   │   └── HLSL files       
│   ├── Scenes/              
│   ├── Prefabs/             
│   ├── Sprites/             
│   └── Audio/               
├── ProjectSettings/         
├── Packages/                
└── .gitattributes           
🚀 Getting Started
Prerequisites
Unity 2021.3 LTS or newer

Git for version control

Installation
Clone the repository:

bash
git clone https://github.com/binodsth2/Flappy-Bird-Game-in-Unity.git
Open in Unity Hub

Run the game from the main scene

How to Play
Click Start in the main menu

Press Spacebar or Mouse Click to flap

Navigate through pipe gaps

Avoid collisions with pipes and ground

Each passed pipe pair awards 1 point

🏗️ System Architecture

















Core Components
Bird Controller: Handles player input and physics response

Pipe Spawner: Manages obstacle generation and movement

Game Manager: Central controller for game states

Score Manager: Tracks and persists scoring data

Shader System: Custom visual effects pipeline

🎓 Learning Journey
Course-Based Development
This project was developed following comprehensive instruction from:

🎯 Flappy Bird from Scratch (Unity 6)
Instructor: Caroline Middlebrook

Key Skills Acquired
Skill Area	Implementation in Project
Unity Basics	Scene setup, GameObject hierarchy, component system
C# Programming	Game logic, event handling, state management
Physics 2D	Rigidbody2D, Colliders, gravity simulation
UI System	Canvas, Text components, screen transitions
Shader Programming	Visual effects using ShaderLab and HLSL
Audio Integration	Sound effects and background music
Development Milestones
Project Setup: Unity configuration and asset organization

Core Mechanics: Bird physics and pipe spawning system

Game Logic: Score tracking and collision detection

Polish Phase: UI implementation and audio integration

Visual Enhancement: Custom shader development

🙏 Special Thanks
To My Instructor
A heartfelt thank you to Caroline Middlebrook for creating the excellent Flappy Bird from Scratch (Unity 6) course. Your clear explanations, step-by-step guidance, and practical teaching approach made this learning journey both enjoyable and educational.

Course Highlights
Comprehensive Coverage: From Unity basics to advanced shader programming

Practical Approach: Hands-on development with real-time problem solving

Best Practices: Industry-standard coding patterns and project organization

Visual Focus: Emphasis on creating polished, visually appealing games

Learning Outcomes
This course helped me master:

Game architecture and state management

Physics-based gameplay mechanics

Professional Unity development workflows

Problem-solving through iterative development

Creating complete, shippable game projects

🔧 Technical Implementation
Language Distribution
ShaderLab (70.9%): Unity's shader definition language for visual effects

HTML (13.8%): Web interface and documentation components

HLSL (12.3%): High-level shader language for GPU programming

C# (3.0%): Game logic and systems programming

Key Scripts
Script	Responsibility	Key Methods
BirdController	Player movement	Flap(), OnCollisionEnter2D()
PipeSpawner	Obstacle management	SpawnPipe(), MovePipes()
GameManager	State control	StartGame(), GameOver()
ScoreManager	Scoring logic	AddScore(), SaveHighScore()
📱 Build & Deployment
WebGL Build
In Unity: File → Build Settings

Select WebGL platform

Configure player settings

Click Build and deploy to web server

Standalone Build
Choose target platform (Windows/Mac/Linux)

Adjust resolution settings

Build executable package

🔄 Version History
Jan 6, 2026: Final code commit - Project completion

Initial commits: Base project setup and asset integration

📄 License
This project is provided for educational and portfolio purposes. All code is available for learning and modification. Please respect licenses of any third-party assets included.

🚀 Next Steps
Building on this foundation, I plan to:

Add power-ups and additional gameplay mechanics

Implement level progression systems

Expand the visual effects library

Optimize for mobile platforms

Add multiplayer functionality

🎮 Try the Game!
Can you beat the high score? This project represents not just code, but the learning journey and skills acquired through dedicated study and practice.

"The beautiful thing about learning is that nobody can take it away from you." - B.B. King
