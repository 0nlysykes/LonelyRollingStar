using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float x_Input, y_Input;
    public float speed = 10;

    private bool rotateLeft = false;
    private bool rotateRight = false;
    public Rigidbody2D playerBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_Input = Input.GetAxis("Horizontal") * speed;
        y_Input = Input.GetAxis("Vertical") * speed;

        if(Input.GetButtonDown("rLeft")){
            rotateLeft = true;
        }

        if(Input.GetButtonDown("rRight")){
            rotateRight = true;
        }

        if(Input.GetButtonUp("rLeft")){
            rotateLeft = false;
        }
        if(Input.GetButtonUp("rRight")){
            rotateRight = false;
        }
    }

    void FixedUpdate() {
        if(rotateLeft && !rotateRight){
            playerBody.angularVelocity += 1.0f;
        } else if (rotateRight && !rotateLeft){
            playerBody.angularVelocity -= 1.0f;
        } else if(rotateLeft && rotateRight){
            playerBody.angularVelocity = 0f;
        }
        playerBody.AddForce(Vector2.right * x_Input, ForceMode2D.Impulse);
        playerBody.AddForce(Vector2.up * y_Input, ForceMode2D.Impulse);
    }
}
