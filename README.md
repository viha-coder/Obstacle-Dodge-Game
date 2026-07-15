# Obstacle Dodge

My First game Using C# and Unity.

## Things I've Learned:

### Version Control With GitHub:

- Learned how to use and configure "GitHub Desktop".
- Solved Problems i had with Github and One Drive.
- Understood the importance of '.gitignore' to exclude heavy Unity folders like 'Library'.
- Learned how to fix repository lock errors by deleting the 'index.lock' file.
- Understood GitHub's visual icons (Green '+' for new files, Yellow for modified files, Red for deleted files).
- Learned how to configure '.gitignore' to exclude Folder like UserSettings and Logs.
- Created a '.gitattributes' file using VS Code

### C# and Variable Scope:

- Understood the practical diferences between "Global Variables" (Fields at the top of the class) and "Local Variables" (created inside functions).
- Practiced "Refactoring" by creating an isolated function called 'spinObject()'.
- Mastered the use of 'Time.deltaTime' to ensure objects movements are time-based, rather than dependent on the computer's frame rate (FPS).
- Modified the 'Scorer.cs' script to filter collisions and only count objects matching the '!= "Hit"' condition.

### Hardware Challenges (8GB RAM Optimization):

- Learned to Optimize the Unity environment by disabling 'Auto Refresh' and using manual compilation ('CTRL + R').

### Rigidbody Physics:

- Fixed a bug where the player kept sliding after colliding with an obstacle, caused by mixing 'transform.Translate' with an active Rigidbody. Solved by moving player movement to 'FixedUpdate()'[...]
- Learned that objects using 'transform.Rotate()' don't interact with physics, even with a Rigidbody attached.
- Fixed a spinning obstacle to properly push the player by adding a Kinematic Rigidbody and switching to 'rb.MoveRotation()' inside 'FixedUpdate()'.
- Understood the importance of using 'Time.fixedDeltaTime' (not 'Time.deltaTime') when working inside 'FixedUpdate()'.

### Refactoring and Bug Fixing:

- Refactored a 'DestroyWhenReached()' method that used '==' to compare 'Vector3' positions (which rarely works due to floating point precision) to use 'Vector3.Distance()' with a tolerance value[...]
- Refactored 5 separate projectile variables into a single 'GameObject[]' array with a 'foreach' loop.
- Fixed a 'MissingReferenceException' caused by trying to reactivate projectiles that had already been destroyed, by disabling the trigger object after first use ('gameObject.SetActive(false)').

### Prefabs:

- Learned that '[SerializeField]' references to scene objects (like the Player) don't carry over automatically when converting an object into a Prefab, since a Prefab needs to work independently[...]
- Fixed broken Prefab instances where the Player reference was missing, causing the game to freeze.

### Object Lifecycle:

- Learned that 'Start()' only runs once, the first time an object becomes active - it does NOT run again when an object is reactivated via 'SetActive(true).'
- Fixed a bug in 'FlyAtPlayer.cs' where the target position was only captured once (in 'Start()'), causing projectiles to always aim at an outdated player position instead of where the player actually was when relaunched.

### Timers and Scene Restarts:

- Fixed a bug in 'Dropper.cs' where obstacles ignored their spawn after the scene restarted. The cause: comparing 'Time.time' directly against a fixed delay only works once, since 'Time.time' keeps counting from the moment the game started, not from when each object was created.
- Solved by storing the moment each object was created ('TimeWhenSpawned = Time.time' in 'Start()') and comparing the elapsed time since then ('Time.time - TimeWhenSpawned > TimeToWait') instead of comparing against global game time.

### Finishing the First Game:

- Implemented a life system on my own (not covered by the course yet): the player has 3 hits before the scene restarts.
- Built my own map from scratch to practice applying everything learned, instead of just following the course's default layout.
- Publesed a playable build via Unity Play, so the game can be tested directly in the browser.
- Link: https://play.unity.com/en/games/a6322b5e-5f54-4734-95b0-dc4e06979259/obstacle-dodge-novo
