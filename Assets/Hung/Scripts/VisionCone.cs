﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<MeshRenderer>().material = gameObject.transform.parent.GetComponent<MeshRenderer>().material;
    }
}
