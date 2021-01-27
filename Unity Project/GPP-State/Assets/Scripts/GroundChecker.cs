using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public Transform groundChecker;
    public bool isGrounded;

    private float _jumpCountDown;
    private float _jumpDelay = 0.5f;
    void Update()
    {

        if(_jumpCountDown > 0f)
        {
            _jumpCountDown -= Time.deltaTime;
            isGrounded = false;
        }
        else
        {
            isGrounded = Physics.CheckSphere(groundChecker.position, groundDistance, groundMask);
        }
    }
    public void Jump()
    {
        _jumpCountDown = _jumpDelay;
    }
}
