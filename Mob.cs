using Godot;
using System;

public partial class Mob : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		string[] mobAnimations = animatedSprite2D.SpriteFrames.GetAnimationNames();
		animatedSprite2D.Play(mobAnimations[GD.Randi() % mobAnimations.Length]);
	}

	private void OnVisibleOnScreenNotifier2DScreenExited()
	{
		QueueFree();
	}
}
