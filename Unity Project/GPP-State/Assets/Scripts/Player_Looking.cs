using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Looking : MonoBehaviour
{
    private Player _player;
    private Camera _camera;
    private PlayerSettings _playerSettings;
    private StateMachine _stateMachine;
    private PlayerAbility[] _abilities;


    public void Initilize(
        Player player,
        Camera camera,
        PlayerSettings playerSettings,
        PlayerAbility[] abilities
        )
    {
        _abilities = abilities;
        _player = player;
        _camera = camera;
        _playerSettings = playerSettings;
    }

    private void Start()
    {
        _stateMachine = new StateMachine();

        var normalMouselook = new PLS_NormalMouseLook(_player, _camera, _playerSettings);

        _stateMachine.SetState(normalMouselook);

        void At(IState to, IState from, Func<bool> condition)
        {
            _stateMachine.AddTransition(from: to, to: from, condition);
        }
    }

    private void Update() => _stateMachine.Tick();

}
