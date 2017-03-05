using UnityEngine;
using System.Collections;

public class playerAni : MonoBehaviour {

    private bool ableToJump = true;

    private HashID hash;
    private Animator ani;
	void Start () {
        hash = GetComponent<HashID>();
        ani = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!Input.GetAxis("Vertical").Equals(0))
            ani.SetFloat(hash.speed, 5 * Input.GetAxis("Vertical"));

        else if (Input.GetAxis("Vertical").Equals(0))
            ani.SetFloat(hash.speed, 0);


        ani.SetFloat(hash.strafe, Input.GetAxis("Strafe"));

        if (!Input.GetAxis("Jump").Equals(0) && ableToJump)
        {
            ableToJump = false;
            ani.SetBool(hash.jump, true);
            
        }
        else
        {
            ani.SetBool(hash.jump, false);
            //ableToJump = true;
        }
    }
    void OnCollisionStay(Collision col)
    {
       // Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag.Equals("Ground") && Input.GetAxis("Jump").Equals(0))
            ableToJump = true;
    }
}
