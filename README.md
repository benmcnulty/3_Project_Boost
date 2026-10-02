# Project Boost

A historical GameDev.tv Unity 3D course project (Section 3), as identified in the
repository description. It records course-guided Unity/C# learning from 2018;
it is not represented as a independently authored commercial game.

## Review the implementation

[`Rocket.cs`](Assets/Scripts/Rocket.cs) handles thrust/rotation, collisions,
audio/particle feedback and level transitions. [`Oscillator.cs`](Assets/Scripts/Oscillator.cs)
animates obstacles. The rocket uses Space for thrust and A/D for rotation;
development-only L/C controls skip a level and toggle collisions.

## Open locally

[`ProjectSettings/ProjectVersion.txt`](ProjectSettings/ProjectVersion.txt) records
**Unity 2018.2.16f1**. Use a complete checkout with all referenced assets and open
its root as a Unity project. A sparse code review is not enough to run the scenes.
Inspect the scene list in Editor Build Settings, then enter Play mode. Modern
Unity versions may require migration; use a separate copy rather than silently
rewriting the historical project.

No npm/Python installation, provider key or runtime environment configuration is
declared. No automated Unity test suite, CI workflow or packaged playable release
is documented in this checkout. This review inspected project settings and C#
source without launching Unity, importing assets or validating gameplay/builds.

## Attribution and rights

Preserve the GameDev.tv course attribution and any Unity/third-party asset notices.
No repository-wide license is committed. Included course code and asset packs
must not be assumed to be original or freely redistributable; their individual
rights have not been audited here. Contributions should preserve the historical
editor baseline and include actual scene/build checks for behavior changes.
