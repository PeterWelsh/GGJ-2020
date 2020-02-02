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

    ParticleSystem particle;


    bool green, red, blue, yellow, pink;

    Pick_up pick;

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
            pick = frog.GetComponent<Pick_up>();
            frog.transform.localPosition = GreenPose.transform.position;
            frog.transform.localRotation = GreenPose.transform.rotation;
            particle = frog.transform.GetComponentInChildren<ParticleSystem>();
            particle.Play();
            pick.enabled = false;

            green = true;
            Debug.Log("Help");
            
        }
        if (frog == Yellowfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = YellowPose.transform.position;
            frog.transform.localRotation = YellowPose.transform.rotation;
            particle = frog.transform.GetComponentInChildren<ParticleSystem>();
            particle.Play();
            pick = frog.GetComponent<Pick_up>();
            pick.enabled = false;

            yellow = true;
            Debug.Log("Help");
        }
        if (frog == Redfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = RedPose.transform.position;
            frog.transform.localRotation = RedPose.transform.rotation;
            particle = frog.transform.GetComponentInChildren<ParticleSystem>();
            particle.Play();
            pick = frog.GetComponent<Pick_up>();
            pick.enabled = false;

            red = true;
            Debug.Log("Help");
        }
        if (frog == Bluefrog)
        {
            frog.transform.parent = null;
            pick = frog.GetComponent<Pick_up>();
            frog.transform.localPosition = BluePose.transform.position;
            frog.transform.localRotation = BluePose.transform.rotation;
            particle = frog.transform.GetComponentInChildren<ParticleSystem>();
            particle.Play();
            pick.enabled = false;

            blue = true;
            Debug.Log("Help");
        }
        if (frog == Pinkfrog)
        {
            frog.transform.parent = null;
            frog.transform.localPosition = PinkPose.transform.position;
            frog.transform.localRotation = PinkPose.transform.rotation;
            particle = frog.transform.GetComponentInChildren<ParticleSystem>();
            particle.Play();
            pick = frog.GetComponent<Pick_up>();
            pick.enabled = false;

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
