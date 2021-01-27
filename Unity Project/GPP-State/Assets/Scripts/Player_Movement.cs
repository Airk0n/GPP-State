using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Player _player;
    private Camera _camera;
    private PlayerSettings _playerSettings;
    private CharacterController _characterController;
    private GroundChecker _groundChecker;
    private Player_Ability[] _abilities;

    private StateMachine _stateMachine;
    public void Initilize(
        Player player,
        Camera camera,
        PlayerSettings playerSettings,
        Player_Ability[] abilities,
        CharacterController characterController,
        GroundChecker groundChecker

        )
    {
        _abilities = abilities;
        _player = player;
        _camera = camera;
        _playerSettings = playerSettings;
        _characterController = characterController;
        _groundChecker = groundChecker;

    }


    private void Awake()
    {
        _stateMachine = new StateMachine();

        var run = new PMS_Run(_player, _playerSettings, _characterController, _groundChecker);
        var jump = new PMS_Jump(_player, _playerSettings, _characterController, _groundChecker);

        //At(run, jump, JumpKeyAndGrounded());
        //At(jump, run, Landed());

        _stateMachine.SetState(run);

        void At(IState to, IState from, Func<bool> condition)
        {
            _stateMachine.AddTransition(from: to, to: from, condition);
        }

        Func<bool> JumpKeyAndGrounded() => () => _groundChecker.isGrounded && Input.GetKeyDown(KeyCode.Space);
        Func<bool> Landed() => () => _groundChecker.isGrounded;


    }

    private void Update()
    {
        _stateMachine.Tick();

    }
}
