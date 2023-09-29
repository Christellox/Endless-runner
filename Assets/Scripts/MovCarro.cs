using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovCarro : MonoBehaviour
{
    public float speed;//, rotationSpeed;
    private float verticalMove, horizontalMove;
/*     public int vida;
    public TMP_Text display_vida;
    public GameObject screen; */

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");

        this.transform.Translate(Time.deltaTime * speed * horizontalMove, 0, 0);
        //this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalMove); 
    }


}
