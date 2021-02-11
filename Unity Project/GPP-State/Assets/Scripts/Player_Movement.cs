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
    private PlayerAbility[] _abilities;

    private StateMachine _stateMachine;
    public void Initilize(
        Player player,
        Camera camera,
        PlayerSettings playerSettings,
        PlayerAbility[] abilities,
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

        var normalRun = new PMS_Run(_player, _playerSettings, _characterController, _groundChecker);

        var qSlot = compareState(_abilities[0], normalRun);
        var eSlot = compareState(_abilities[1], normalRun);
        var rSlot = compareState(_abilities[2], normalRun);
        var fSlot = compareState(_abilities[3], normalRun);
        var cSlot = compareState(_abilities[4], normalRun);



        //At(run, jump, JumpKeyAndGrounded());
        //At(jump, run, Landed());

        _stateMachine.SetState(normalRun);

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

    private IState compareState(PlayerAbility abilityCheck, IState defaultState)
    {
        var testState = abilityCheck.GetMoveState(_player,_characterController);

        if(testState != defaultState)
        {
            return abilityCheck.GetMoveState(_player, _characterController);
        }

        return defaultState;
    }

}
