using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityCooldowns
{
    private PlayerAbility[] _abilities;

    private float[] _coolDowns;

    public void Initialize(PlayerAbility[] abilities)
    {
        _abilities = abilities;
        
    }

    public void Tick()
    {
        
    }

}
