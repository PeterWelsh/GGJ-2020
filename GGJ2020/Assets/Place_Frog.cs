using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Frog : MonoBehaviour
{
    public GameObject Greenfrog;
    public GameObject Redfrog;
    public GameObject Yellowfrog;
    public GameObject Bluefrog;
    public GameObject Pinkfrog;

    public GameObject GreenPose;
    public GameObject RedPose;
    public GameObject YellowPose;
    public GameObject BluePose;
    public GameObject PinkPose;

    bool green, red, blue, yellow, pink;



    private void Update()
    {
        if(green == true && red == true && blue == true &&  yellow == true && pink == true)
        {
            Debug.Log("YouWin");
            //YOU WIN!
        }
    }

    public void PlaceOnStand(GameObject frog)
    {
       if(frog == Greenfrog)
        {
            frog.transform.parent = null;
          
            frog.transform.localPosition = GreenPose.transform.position;

            green = true;
            Debug.Log("Help");
            
        }
        if (frog == Yellowfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = YellowPose.transform.position;

            yellow = true;
            Debug.Log("Help");
        }
        if (frog == Redfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = RedPose.transform.position;

            red = true;
            Debug.Log("Help");
        }
        if (frog == Bluefrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = BluePose.transform.position;

            blue = true;
            Debug.Log("Help");
        }
        if (frog == Pinkfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = PinkPose.transform.position;

            pink = true; 
            Debug.Log("Help");
        }
        else
        {
            Debug.Log("FUCK");
            //nothing
        }

    }
}
