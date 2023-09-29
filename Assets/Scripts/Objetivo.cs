using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo : MonoBehaviour
{
    public GameObject obj;
    public bool activo = false;

    public float speed;

    public static bool primero = true;
    
    public void ssetActive(bool activo){
        this.gameObject.SetActive(activo);
        activo = activo;
    }

    // Start is called before the first frame update
    void Start()
    {   
         this.gameObject.SetActive(false);
         activo = false;
        
    }

    

    void LateUpdate()
    {
        if(activo){
            this.transform.Translate(0, 0, - Time.deltaTime * speed );
        }
    }   

}
