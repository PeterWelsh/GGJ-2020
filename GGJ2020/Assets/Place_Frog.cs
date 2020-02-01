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

  
   public void PlaceOnStand(GameObject frog)
    {
       if(frog == Greenfrog)
        {
            frog.transform.parent = null;
            frog.transform.parent = gameObject.transform.GetChild(0);
            frog.transform.localPosition = gameObject.transform.GetChild(0).localPosition;
            Debug.Log("Help");
            
        }
        if (frog == Yellowfrog)
        {

            frog.transform.parent = null;
            frog.transform.parent = gameObject.transform.GetChild(1);
            frog.transform.localPosition = gameObject.transform.GetChild(1).localPosition;
            Debug.Log("Help");
        }
        if (frog == Redfrog)
        {

            frog.transform.parent = null;
            frog.transform.parent = gameObject.transform.GetChild(2);
            frog.transform.localPosition = gameObject.transform.GetChild(2).localPosition;
            Debug.Log("Help");
        }
        if (frog == Bluefrog)
        {

            frog.transform.parent = null;
            frog.transform.parent = gameObject.transform.GetChild(3);
            frog.transform.localPosition = gameObject.transform.GetChild(3).localPosition;
            Debug.Log("Help");
        }
        if (frog == Pinkfrog)
        {

            frog.transform.parent = null;
            frog.transform.parent = gameObject.transform.GetChild(4);
            frog.transform.localPosition = gameObject.transform.GetChild(4).localPosition;
            Debug.Log("Help");
        }
        else
        {
            Debug.Log("FUCK");
            //nothing
        }

    }
}
