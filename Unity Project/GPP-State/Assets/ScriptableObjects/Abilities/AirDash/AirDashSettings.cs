using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AirDash settings", menuName = "player/abilites/AirDash")]
public class PlayerAirDashSettings : PlayerAbility
{
    public FloatReference distance;
    public FloatReference speed;
    private IState _airDashState;

    public void Awake()
    {
        abilityType = AbilityType.AirDash;
    }
    public override IState GetMoveState(Player player, CharacterController characterController)
    {
        _airDashState = new PMS_AirDash(characterController, player);
        return _airDashState;
    }
    public override IState GetLookState(Player player, CharacterController characterController)
    {
        _airDashState = new PMS_AirDash(characterController, player);
        return _airDashState;
    }
    public override IState GetEquipState(Player player, CharacterController characterController)
    {
        _airDashState = new PMS_AirDash(characterController, player);
        return _airDashState;
    }


}