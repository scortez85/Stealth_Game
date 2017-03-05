using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
    public bool isWalking = true;
    public int walkSpeed = 5;
    public int jumpHeight = 100;
    private bool ableToJump = true;

    void Update()
    {
        float vert = Input.GetAxis("Vertical");

        if (isWalking)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed * vert);
            if (!Input.GetAxis("Strafe").Equals(0))
                transform.Translate(Time.deltaTime * walkSpeed * Input.GetAxis("Strafe"), 0, 0);

            if (!Input.GetAxis("Jump").Equals(0) && ableToJump)
            {
                ableToJump = false;
                //transform.Translate(Vector3.up * jumpHeight * Time.deltaTime);
                GetComponent<Rigidbody>().velocity += Vector3.up * jumpHeight;  

            }

        }


    }
    void OnCollisionStay(Collision col)
    {
        //Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag.Equals("Ground") && Input.GetAxis("Jump").Equals(0))
            ableToJump = true;
    }
}
