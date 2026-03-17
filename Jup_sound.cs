using Godot;
using System;

public partial class Jup_sound : AudioStreamPlayer3D
{
	[Export] Player player;
	public override void _Ready()
	{
		player.Jump += OnPlayerJump;
	}


    private void OnPlayerJump(object sender, EventArgs e)
    {
        Play();
    }
}
