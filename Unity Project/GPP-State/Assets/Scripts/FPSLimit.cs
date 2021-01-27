using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimit : MonoBehaviour
{
    public int targetFPS = 144;
    void Start()
    {
        Application.targetFrameRate = targetFPS;
    }

}
