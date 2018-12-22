using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGun : MonoBehaviour
{


    // variables
    public Transform Player;


    // smooth camera
    void LateUpdate()
    {
        transform.position = Player.transform.position;
    }
}
