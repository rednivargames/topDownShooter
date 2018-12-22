using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{


    // variables
    [SerializeField]
    private float Speed;

    private Vector2 DirectionInput;
    private float OriginXInput;
    private float OriginYInput;


    // input
    void Update()
    {
        // set origin
        if (Input.GetMouseButtonDown(0))
        {
            OriginXInput = Input.mousePosition.x;
            OriginYInput = Input.mousePosition.y;
        }
        // set direction
        DirectionInput = new Vector2(Input.mousePosition.x - OriginXInput, 
                                     Input.mousePosition.y - OriginYInput).normalized;
    }


    // move
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(DirectionInput * Speed * Time.deltaTime);
            // set depth
            transform.position = new Vector3(transform.position.x, 
                                             transform.position.y, 
                                             transform.position.y);
        }
    }
}
