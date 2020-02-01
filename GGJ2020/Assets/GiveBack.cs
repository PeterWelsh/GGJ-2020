using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBack : MonoBehaviour
{
    public GameObject Owner;
    public bool Return;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Return == true)
        {
            transform.parent = Owner.transform;
            transform.localScale = new Vector3(1f, 1f, 1f);
            transform.localPosition = new Vector3(0.4f, 38.1f, 26.6f);
            transform.localRotation = new Quaternion(97.0f, -1.53f, -1.53f, 0.0f);
        }
       
    }
}
