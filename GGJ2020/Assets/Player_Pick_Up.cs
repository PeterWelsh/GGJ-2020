using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pick_Up : MonoBehaviour
{
    
    Pick_up pick_Up;
    Place_Frog place_Frog;
    GameObject leftItem;
    GameObject RightItem;
    GameObject collisonItem;
    bool player_PU;
    bool player_Place;
    bool hands_full;
    bool left_hand_full;
    bool right_hand_full;
    // Start is called before the first frame update
    void Start()
    {
        player_PU = false;
        player_Place = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0).Equals(true))
        {
            if (player_Place == false)
            {

                if (left_hand_full == true)
                {

                    Debug.Log("Drop");
                    pick_Up = leftItem.GetComponent<Pick_up>();
                    pick_Up.drop = true;
                    left_hand_full = false;


                }

                else if (player_PU == true)
                {
                    if (left_hand_full == false)
                    {
                        leftItem = collisonItem;
                        pick_Up = leftItem.GetComponent<Pick_up>();
                        pick_Up.pickupL = true;
                        player_PU = false;
                        left_hand_full = true;
                    }


                }

                

            }

            else if (player_Place == true)
            {
                place_Frog.PlaceOnStand(leftItem);
                Debug.Log(leftItem);
            }

        }

        if (Input.GetMouseButtonDown(1).Equals(true))
        {
            if(player_Place == false)
            {
                if (right_hand_full == true)
                {
                    pick_Up = RightItem.GetComponent<Pick_up>();
                    pick_Up.drop = true;
                    right_hand_full = false;
                }

                else if (player_PU == true)
                {

                    if (right_hand_full == false)
                    {
                        RightItem = collisonItem;
                        pick_Up = RightItem.GetComponent<Pick_up>();
                        pick_Up.pickupR = true;
                        player_PU = false;
                        right_hand_full = true;
                    }


                }
            }

            else if(player_Place == true)
            {
                place_Frog.PlaceOnStand(RightItem);

               
            }
      
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Pick_up>() != null)
        {
            collisonItem = other.gameObject;
            pick_Up = other.gameObject.GetComponent<Pick_up>();

            player_PU = true;
        }

        if(other.gameObject.GetComponent<Place_Frog>()!=null)
        {
            
            place_Frog = other.gameObject.GetComponent<Place_Frog>();

            player_Place = true;

            Debug.Log("place");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Pick_up>() != null)
        {
            collisonItem = null;
            pick_Up = null;

            player_PU = false;
        }

        if (other.gameObject.GetComponent<Place_Frog>() != null)
        {
            
            player_Place = false;

            Debug.Log("leave");
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{

    //    if (other.gameObject.GetComponent<Pick_up>() != null)
    //    {
    //        collisonItem = other.gameObject;
    //        pick_Up = other.gameObject.GetComponent<Pick_up>();

    //        player_PU = true;
    //    }
    //}


}
