using UnityEngine;
using System.Collections;

public static class Keyboard {

    
	public static bool isKeyDown(KeyCode key)
    {
        return Input.GetKey(key);
    }
}
