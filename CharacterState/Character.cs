using System;
using System.Collections.Generic;
using System.Text;

public class Character
{
    public enum CharacterState
    {
        Idle,
        Walking,
        Running,
        Jumping,
        Attacking,
        Dead
    }
    public CharacterState State { get; set; }

    public Character()
    {
        State = CharacterState.Idle;
    }
}
