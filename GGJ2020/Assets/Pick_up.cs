using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up : MonoBehaviour
{
    private Vector3 startingPos;
    public Vector3 pickup_posL;
    public Vector3 pickup_posR;
    //var pickupRot;
    Material material;
    public Vector3 pickup_scale;
    public Vector3 drop_scale;
    public bool pickupL;
    public bool pickupR;

    private bool in_hand;
    public bool drop;
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject Player;
    Collider box;
    Rigidbody rigidbody;
    [SerializeField]
    private Canvas UI;

    // Use this for initialization
    void Start()
    {
        startingPos = transform.position;
        GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineSize", 0.0f);
        box = GetComponent<Collider>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        if (drop == true)
        {
          
            transform.parent = null;
            transform.position = new Vector3(transform.position.x, Player.transform.position.y - 1f, transform.position.z);
            transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f,0.0f);
            //Debug.Log("grab");
            drop = false;
            pickupL = false;
            pickupR = false;
            in_hand = false;

        }

        else if (pickupL == true && in_hand == false)
        {
            
            transform.parent = LeftHand.transform;
            transform.localPosition = pickup_posL;
            transform.localRotation = transform.rotation;
            transform.localScale = pickup_scale;
            pickupL = false;

            in_hand = true;
            GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineSize", 0.0f);
        }

        else if (pickupR == true && in_hand == false)
        {
          
            transform.parent = RightHand.transform;
            transform.localPosition = pickup_posR;
            transform.localRotation = transform.rotation;
            transform.localScale = pickup_scale;
            pickupR = false;
            in_hand = true;
            GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineSize", 0.0f);

        }





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player_Movement>() != null)
        {

            if(in_hand == false)
            {
                GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineSize", 2.0f);
            }
           

           


        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Player_Movement>() != null)
        {
          

            GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineSize", 0.0f);
        }

    }


}
