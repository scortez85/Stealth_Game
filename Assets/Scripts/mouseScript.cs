using UnityEngine;
using System.Collections;

public class mouseScript : MonoBehaviour {

    public bool hideMouse;
    public CursorLockMode mouseLockMode;
    void Start()
    {
        Cursor.visible = !hideMouse;
        Cursor.lockState = mouseLockMode;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
