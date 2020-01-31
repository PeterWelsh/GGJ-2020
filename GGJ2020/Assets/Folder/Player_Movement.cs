using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

   
    public float speed = 2.0f;
    public float sensitivity = 2.0f;
    CharacterController player;

    public GameObject eyes;
    bool is_moving;

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

    }
	
	// Update is called once per frame
	void Update ()
    {
        target_time -= Time.deltaTime;

        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity * -1;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
      
        
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(rotY, 0, 0);


        movement = transform.rotation * movement;

    
        

        player.Move(movement * Time.deltaTime);


    }
}
