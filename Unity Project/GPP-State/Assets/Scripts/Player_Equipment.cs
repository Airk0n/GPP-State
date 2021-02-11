using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Equipment : MonoBehaviour
{
    private Player _player;
    private Camera _camera;
    private PlayerSettings _playerSettings;
    private StateMachine _stateMachine;
    private CharacterController _characterController;
    private PlayerAbility[] _abilities;


    public void Initilize(
        Player player,
        Camera camera,
        PlayerSettings playerSettings,
        PlayerAbility[] abilities,
        CharacterController characterController

        )
    {
        _abilities = abilities;
        _player = player;
        _camera = camera;
        _playerSettings = playerSettings;
        _characterController = characterController;

    }

    private void Start()
    {
        _stateMachine = new StateMachine();

        var unequiped = new PES_unequip();

        _stateMachine.SetState(unequiped);

        void At(IState to, IState from, Func<bool> condition)
        {
            _stateMachine.AddTransition(from: to, to: from, condition);
        }
    }
}
