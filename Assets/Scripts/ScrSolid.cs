﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrSolid : MonoBehaviour
{


	// set depth
	void Start ()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
