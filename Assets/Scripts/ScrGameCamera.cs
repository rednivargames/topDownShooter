using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGameCamera : MonoBehaviour
{


    // variables
    public Transform Player;
    public float Smoothness;
    private float XPosition;
    private float YPosition;
	

	// smooth camera
	void LateUpdate()
    {
        XPosition += (Player.position.x - transform.position.x) * Smoothness;
        YPosition += (Player.position.y - transform.position.y) * Smoothness;
        transform.position = new Vector3(XPosition, YPosition, -100);
	}
}
