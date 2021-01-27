using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new airDash settings", menuName = "player/abilites/airDash")]
public class PlayerAirDashSettings : Player_Ability
{
    public FloatReference distance;
    public FloatReference speed;
    private IState _airDashState;

    public void Awake()
    {
        abilityType = AbilityType.AirDash;
    }
    public override IState DefineState(Player player, CharacterController characterController, OrbLauncher orbLauncher)
    {
        _airDashState = new PMS_AirDash(characterController, player);
        return _airDashState;
    }


}