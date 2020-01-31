using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up : MonoBehaviour
{
    private Vector3 startingPos;
    public Vector3 pickup_pos;
    public Vector3 pickup_rot;
    public Vector3 pickup_scale;
    public bool pickup;
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
       
        if (pickup == true)
        {
            transform.parent = player.transform;
            transform.localPosition = pickup_pos;
            transform.localScale = pickup_scale;
            

        }

        if (pickup == false)
        {
            transform.parent = null;
        }

        

    }
}
