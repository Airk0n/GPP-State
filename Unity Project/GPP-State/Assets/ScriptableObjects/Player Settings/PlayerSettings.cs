using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new player settings", menuName = "player/settings")]
public class PlayerSettings : ScriptableObject
{
    public float weight;
    public float walkSpeed;
    public float runSpeed;
    public float mouseSensitivity;
    public float jumpVel;

}
