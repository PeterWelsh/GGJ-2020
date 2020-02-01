using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pick_Up : MonoBehaviour
{
    Pick_up pick_Up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("grab");

        if (other.gameObject.GetComponent<Pick_up>() != null)
        {
            pick_Up = other.gameObject.GetComponent<Pick_up>();
            pick_Up.pickup = true;

           
        }
    }
}
