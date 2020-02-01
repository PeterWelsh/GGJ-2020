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


    public void PlaceOnStand(GameObject frog)
    {
       if(frog == Greenfrog)
        {
            frog.transform.parent = null;
          
            frog.transform.localPosition = GreenPose.transform.position;
            Debug.Log("Help");
            
        }
        if (frog == Yellowfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = YellowPose.transform.position;
            Debug.Log("Help");
        }
        if (frog == Redfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = RedPose.transform.position;
            Debug.Log("Help");
        }
        if (frog == Bluefrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = BluePose.transform.position;
            Debug.Log("Help");
        }
        if (frog == Pinkfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = PinkPose.transform.position;
            Debug.Log("Help");
        }
        else
        {
            Debug.Log("FUCK");
            //nothing
        }

    }
}
