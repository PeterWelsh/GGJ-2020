using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apology : MonoBehaviour
{
    Friend_Status friend_;
    Player_Pick_Up player_Pick_Up;
    public GameObject GreenFrog;
    int bandnum;

    // Start is called before the first frame update
    void Start()
    {
        player_Pick_Up = GetComponent<Player_Pick_Up>();
        bandnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            sorry(player_Pick_Up.leftItem, player_Pick_Up.RightItem);
            sorry(player_Pick_Up.RightItem, player_Pick_Up.leftItem);
        }

        if (bandnum >= 4)
        {
            friend_ = GreenFrog.GetComponent<Friend_Status>();
            if (friend_.BackInBand == false)
            {

                friend_.BackInBand = true;
            }
        }
    }

    void sorry(GameObject Frog1, GameObject Frog2)
    {
        if (Frog1 != GreenFrog && Frog2 != GreenFrog)
        {
            if (Frog1.GetComponent<Friend_Status>() != null && Frog2.GetComponent<Friend_Status>() != null)
            {


                friend_ = Frog1.GetComponent<Friend_Status>();
                if (friend_.BackInBand == false)
                {

                    friend_.BackInBand = true;
                    bandnum++;

                }

                friend_ = Frog2.GetComponent<Friend_Status>();
                if (friend_.BackInBand == false)
                {

                    friend_.BackInBand = true;
                    bandnum++;
                }






            }
        }



    }
}
