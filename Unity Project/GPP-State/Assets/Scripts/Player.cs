using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Abilities")]
    [SerializeField] private Player_Ability[] _abilities;


    [Header("StateMachines")]
    [SerializeField] private Player_Movement _playerMove;
    [SerializeField] private Player_Equipment _playerEquip;
    [SerializeField] private Player_Looking _playerLook;

    [Header("Settings")]
    [SerializeField] private PlayerSettings _playerSettings;

    [Header("Components")]
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private GroundChecker _groundChecker;




    private void Awake()
    {
        _playerLook.Initilize(this,Camera.main,_playerSettings, _abilities);
        _playerMove.Initilize(this, Camera.main, _playerSettings, _abilities, _characterController, _groundChecker);
        _playerEquip.Initilize(this, Camera.main, _playerSettings, _abilities ,_characterController);
    }




}
