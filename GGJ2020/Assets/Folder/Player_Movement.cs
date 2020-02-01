using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float speed = 2.0f;
    public float sensitivity = 2.0f;
    public float gravity = 9.8f;
    public float smooth = 2.0f;

    float jumpSpeed = 8.0f;
    float vSpeed = 0.0f;
    float startHeight;

    CharacterController player;

    public GameObject eyes;
    bool is_moving;
    bool is_crouching = false;

    float moveFB;
    float moveLR;

    float rotX;
    float rotY;

    float target_time = 0.25f;

    Vector3 last_Move;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<CharacterController>();
        startHeight = player.height;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //crouch_pos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

        target_time -= Time.deltaTime;

        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity * -1;

        if(player.isGrounded)
        {
            vSpeed = 0;
            if(Input.GetKeyDown("space"))
            {
                vSpeed = jumpSpeed;
            }
        }

        vSpeed -= gravity * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            is_crouching = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {

            is_crouching = false;
        }

        if(is_crouching)
        {
            Debug.Log("Crouched");
            player.height = startHeight / 2;
        }
        else
        {
            Debug.Log("Uncrouched");
            player.height = startHeight;
        }

        Vector3 movement = new Vector3(moveLR, vSpeed, moveFB);

        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(rotY, 0, 0);

        movement = transform.rotation * movement;

        player.Move(movement * Time.deltaTime);
    }
}
