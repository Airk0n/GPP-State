using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBuffer : MonoBehaviour
{
    // scriptable object with key fortgiveness values
    private KeyCode keyDown;
    private void Update()
    {
        switch (keyDown)
        {
            case KeyCode.Space:
                new InputTimer(KeyCode.Space, 4f);
                break;

        }
    }
}

public class InputTimer : MonoBehaviour
{
    public KeyCode _key;
    public bool active;

    private float _cooldown;

    public InputTimer(KeyCode key, float cooldown)
    {
        active = true;
        _key = key;
        _cooldown = cooldown;
    }
    
    private void Update()
    {
        if(_cooldown > 0f)
        {
            _cooldown -= Time.deltaTime;
        }
        if(_cooldown <= 0f)
        {
            active = false;
        }
    }

}
