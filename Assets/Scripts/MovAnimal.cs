using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAnimal : MonoBehaviour
{
    // Start is called before the first frame update
     public float speed;
    void LateUpdate()
    {
        
        this.transform.Translate(0, 0, Time.deltaTime * speed );
    }
}
