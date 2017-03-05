using UnityEngine;
using System.Collections;

public class HashID : MonoBehaviour {

    public int speed,strafe,jump;
	void Start () {
        speed = Animator.StringToHash("speed");
        strafe = Animator.StringToHash("strafe");
        jump = Animator.StringToHash("jump");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
