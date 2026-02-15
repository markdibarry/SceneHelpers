using Godot;

namespace GameCore.SceneHelpers;

public interface IScene
{
    static abstract string TscnPath { get; }

    static PackedScene LoadPackedScene<T>() where T : Node, IScene
    {
        return GD.Load<PackedScene>(T.TscnPath);
    }

    static T Instantiate<T>() where T : Node, IScene
    {
        return LoadPackedScene<T>().Instantiate<T>();
    }
}