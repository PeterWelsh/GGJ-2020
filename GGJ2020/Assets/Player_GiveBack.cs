using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GiveBack : MonoBehaviour
{
    GiveBack gibL;
    GiveBack gibR;
    Friend_Status friend;
    public GameObject Left;
    public GameObject right;
    GameObject owner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Left != null)
        {
            gibL = Left.GetComponent<GiveBack>();
        }
        if (right != null)
        {
            gibR = right.GetComponent<GiveBack>();
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(owner != null)
            if (gibL != null)
            if(owner = gibL.Owner)
            {
                gibL.Return = true;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (owner != null)
                if (gibL != null)
                    if (owner = gibR.Owner)
            {
                gibR.Return = true;
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Friend_Status>())
        {
            owner = other.gameObject; 
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.GetComponent<Friend_Status>())
        {
            owner = null;
        }
    }
}
