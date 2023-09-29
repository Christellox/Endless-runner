using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMov : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        this.transform.Translate(0,0,speed*Time.deltaTime);
    }
}
