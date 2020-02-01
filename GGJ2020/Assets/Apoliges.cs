using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apoliges : MonoBehaviour
{
    public GameObject Greenfrog;
    public GameObject Redfrog;
    public GameObject Yellowfrog;
    public GameObject Bluefrog;
    public GameObject Pinkfrog;
    Friend_Status friend_;
    Player_Pick_Up player_Pick_Up;

    // Start is called before the first frame update
    void Start()
    {
        player_Pick_Up = GetComponent<Player_Pick_Up>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            sorry(player_Pick_Up.leftItem, player_Pick_Up.RightItem);
        }
    }

    void sorry(GameObject Frog1, GameObject Frog2)
    {
        if(Frog1 != null && Frog2 != null)
        {
            if (Frog1 == Bluefrog && Frog2 == Redfrog)
            {
                friend_ = Frog1.GetComponent<Friend_Status>();
                friend_.BackInBand = true;

                friend_ = Frog2.GetComponent<Friend_Status>();
                friend_.BackInBand = true;
            }

            if (Frog1 == Yellowfrog && Frog2 == Pinkfrog)
            {
                friend_ = Frog1.GetComponent<Friend_Status>();
                friend_.BackInBand = true;

                friend_ = Frog2.GetComponent<Friend_Status>();
                friend_.BackInBand = true;
            }
        }
        
    }

}
