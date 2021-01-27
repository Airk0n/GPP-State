using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player_Ability : ScriptableObject
{
    public string abilityName;
    public AbilityType abilityType;
    public FloatReference coolDown;
    public abstract IState DefineState(
        Player player, 
        CharacterController characterController, 
        OrbLauncher orbLauncher
        );
}
