using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMS_Jump : IState
{
    private Vector2 _velocity;
    private Player _player;
    private PlayerSettings _playerSettings;
    private CharacterController _characterController;
    private GroundChecker _groundChecker;

    public PMS_Jump (
        Player player, 
        PlayerSettings playerSettings, 
        CharacterController characterController, 
        GroundChecker groundChecker 
        )
    {
        _player = player;
        _playerSettings = playerSettings;
        _characterController = characterController;
        _groundChecker = groundChecker;

    }

    public bool AbilityCondition()
    {
        return false;
    }

    public void OnEnter()
    {
        _groundChecker.Jump();

        float vel = _characterController.velocity.x;
        vel += _playerSettings.jumpVel;
        _velocity.y = vel;
    }

    public void OnExit()
    {
        
    }

    public void Tick()
    {
        _velocity.y -= _playerSettings.weight * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }

}
