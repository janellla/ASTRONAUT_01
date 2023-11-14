using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleScript : MonoBehaviour
{
    public float speed = 1;
		
    void Update ()
    {
        transform.Translate(speed * (-1), 0, 0);
    }
}
