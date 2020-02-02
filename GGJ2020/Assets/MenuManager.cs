using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject startButt, quitButt, controls, controls2, startText;
    bool ready = false, confirm = true;

    private void Start()
    {
        startButt.SetActive(true);
        quitButt.SetActive(true);
        controls.SetActive(false);
        controls2.SetActive(false);
        startText.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown("space") && confirm == false)
        {
            ready = true;
        }

        if(ready == true)
        {
            SceneManager.LoadScene("MergedScene");
        }
    }

    public void StartGame()
    {
        startButt.SetActive(false);
        quitButt.SetActive(false);
        controls.SetActive(true);
        controls2.SetActive(true);
        startText.SetActive(true);
        confirm = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
