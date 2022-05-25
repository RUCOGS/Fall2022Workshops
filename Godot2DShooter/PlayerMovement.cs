using Godot;
using System;

public class PlayerMovement : Node
{
    [Export]
    private NodePath bodyPath;
    private KinematicBody2D body;
    
    [Export]
    private float speed;

    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        body = GetNode<KinematicBody2D>(bodyPath);
    }

    public override void _EnterTree()
    {
        base._EnterTree();
    }

    public override void _PhysicsProcess(float delta)
    {
        Vector2 direction = Vector2.Zero;
        if (Input.IsKeyPressed((int) KeyList.W))
            direction.y -= 1;
        if (Input.IsKeyPressed((int)KeyList.A))
            direction.x -= 1;
        if (Input.IsKeyPressed((int)KeyList.S))
            direction.y += 1;
        if (Input.IsKeyPressed((int)KeyList.D))
            direction.x += 1;
        body.MoveAndSlide(direction * speed);
    }
}
