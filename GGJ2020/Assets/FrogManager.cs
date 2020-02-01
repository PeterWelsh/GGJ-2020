using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogManager : MonoBehaviour
{
    float rotate = 0;
    public GameObject frog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate += (1 * Time.deltaTime);
        frog.transform.Rotate(0.0f, rotate, 0.0f);
    }
}
