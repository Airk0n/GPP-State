using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMS_AirDash : IState
{
    private CharacterController _characterController;
    private Player _player;
    private Vector3 _dashTarget;
    private bool _isAirDashing;

    public PMS_AirDash(
        CharacterController characterController,
        Player player
        
        )
    {
        _player = player;
        _characterController = characterController;
    }

    public bool AbilityCondition()
    {
        return false;
    }

    public void OnEnter()
    {
        _isAirDashing = true;
        //_dashTarget = Camera.main.transform.position + Camera.main.transform.forward * _airDashSettings.distance.Value - Camera.main.transform.localPosition;
    }

    public void OnExit()
    {
        
    }

    public void Tick()
    {
        /*
        Vector3 moveVector = Vector3.MoveTowards(_characterController.transform.position, _dashTarget, _airDashSettings.speed.Value * Time.deltaTime);
        _characterController.transform.position = moveVector;
        if (Vector3.Distance(_player.transform.position, _dashTarget) < _minDistance)
        {
            _isAirDashing = false;
        }
        */
    }
}
