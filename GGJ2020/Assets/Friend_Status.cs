﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend_Status : MonoBehaviour
{
    public bool BackInBand;
   
    // Start is called before the first frame update
    void Start()
    {
        BackInBand = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(BackInBand == true)
        {
            gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        }
    }
}
