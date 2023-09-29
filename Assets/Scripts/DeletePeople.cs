using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePeople : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "People")
        {
            Destroy(other.gameObject);
        }
    }
}
