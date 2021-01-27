using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMS_Run : IState
{
    private Player _player;
    private PlayerSettings _playerSettings;
    private CharacterController _characterController;
    private GroundChecker _groundChecker;
    private Vector2 _velocity;

    public PMS_Run(Player player, PlayerSettings playerSettings, CharacterController characterController, GroundChecker groundChecker)
    {
        _player = player;
        _playerSettings = playerSettings;
        _characterController = characterController;
        _groundChecker = groundChecker;
    }
    public void OnEnter()
    {

    }

    public void OnExit()
    {

    }

    public void Tick()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = _player.transform.right * x + _player.transform.forward * z;

        _characterController.Move(move * _playerSettings.walkSpeed * Time.deltaTime);

        if (_groundChecker.isGrounded)
        {
            _velocity.y = -2f;
        }

        _velocity.y -= _playerSettings.weight * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);


    }

}
