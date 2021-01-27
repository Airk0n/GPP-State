using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLS_NormalMouseLook : IState
{
    private PlayerSettings _playerSettings;
    private Camera _mainCamera;
    private Player _player;
    private float xRotation;

    public PLS_NormalMouseLook(Player player, Camera camera, PlayerSettings playerSettings)
    {
        _player = player;
        _mainCamera = camera;
        _playerSettings = playerSettings;
    }
    public void OnEnter()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnExit()
    {
        
    }

    public void Tick()
    {
        float mouseX = Input.GetAxis("Mouse X") * _playerSettings.mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _playerSettings.mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        _mainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        _player.transform.Rotate(Vector3.up * mouseX);
    }
}
