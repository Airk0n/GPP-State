using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAbility : ScriptableObject
{
    public string abilityName;
    public AbilityType abilityType;
    public FloatReference coolDown;
    public abstract IState GetMoveState(
        Player player,
        CharacterController characterController
        );
    public abstract IState GetLookState(
        Player player,
        CharacterController characterController
        );

    public abstract IState GetEquipState(
        Player player,
        CharacterController characterController
        );

}
