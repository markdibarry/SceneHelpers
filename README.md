# Scene Helpers

Adds static scene paths to custom Godot Nodes and implements the IScene interface.

```cs
/// <summary>
/// The string path location of your .tscn file
/// </summary>
public static string TscnPath => "/Your/Path/Here.tscn";

/// <summary>
/// Loads a PackedScene from the .tscn file path
/// </summary>
public static PackedScene LoadPackedScene();

/// <summary>
/// Calls LoadPackedScene() then Instantiate<YourClass>()
/// </summary>
public static YourClass Instantiate();
```

Note: Assumes that the .tscn file is in the same folder as the .cs file.