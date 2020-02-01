using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up : MonoBehaviour
{
    private Vector3 startingPos;
    public Vector3 pickup_posL;
    public Vector3 pickup_posR;

    public Vector3 pickup_scale;
    public Vector3 drop_scale;
    public bool pickupL;
    public bool pickupR;
    public bool drop;
    public GameObject player;
    [SerializeField]
    private Canvas UI;

    // Use this for initialization
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        if (drop == true)
        {

            transform.parent = null;
            transform.position = new Vector3(transform.position.x, 0.1f, transform.position.z);
            Debug.Log("grab");
            drop = false;
           
        }

        else if (pickupL == true)
        {
            transform.parent = player.transform;
            transform.localPosition = pickup_posL;
            transform.localScale = pickup_scale;
            pickupL = false;

        }

        else if (pickupR == true)
        {
            transform.parent = player.transform;
            transform.localPosition = pickup_posR;
            transform.localScale = pickup_scale;
            pickupR = false;

        }





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player_Movement>() != null)
        {
            transform.GetChild(0).gameObject.SetActive(true);
     
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Player_Movement>() != null)
        {
            transform.GetChild(0).gameObject.SetActive(false);


        }

    }


}
