using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public GameObject endScreen, endButton;

    ParticleSystem particle;
    Friend_Status friend;


    bool green, red, blue, yellow, pink, finished = false;

    Pick_up pick;

    private void Start()
    {
        endScreen.SetActive(false);
        endButton.SetActive(false);
    }

    private void Update()
    {
        if(green == true && red == true && blue == true &&  yellow == true && pink == true)
        {
            finished = true;
        }

        if(finished == true)
        {
            Debug.Log("YouWin");
            //YOU WIN!
            endScreen.SetActive(true);
            endButton.SetActive(true);
        }
    }

    public void PlaceOnStand(GameObject frog)
    {
        friend = frog.GetComponent<Friend_Status>();
        if (friend.BackInBand == true)
        {
            if (frog == Greenfrog)
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

    public void ReturnHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
