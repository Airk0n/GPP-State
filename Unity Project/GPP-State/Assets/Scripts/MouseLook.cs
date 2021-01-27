using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private PlayerSettings playerSettings;
    private Camera mainCamera;

    private float xRotation;
    public void SetLocalVariables(PlayerSettings playerSettings, Camera mainCamera)
    {
        this.playerSettings = playerSettings;
        this.mainCamera = mainCamera;
    }
    void Update()
    {
        #region mouseLook
        float mouseX = Input.GetAxis("Mouse X") * playerSettings.mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * playerSettings.mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        mainCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
        #endregion
    }
}
