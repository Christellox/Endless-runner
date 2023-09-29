using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCoin : MonoBehaviour
{
    // Start is called before the first frame update    public float speed;
    public float speed;
    void LateUpdate()
    {
        
        this.transform.Translate(0, -Time.deltaTime * speed, 0 );
    }
}
