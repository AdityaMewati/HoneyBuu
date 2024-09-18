using Godot;
using System;

public partial class Pedal : CharacterBody2D
{
	[Export]
    public int Speed { get; set; } = 400;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("");
	}

    public void GetInput()
    {

        Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
		LookAt(Vector2.Zero);
        GetInput();
        MoveAndSlide();
    }
}
