using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Boton_Restart : MonoBehaviour
{
    public void reiniciarJuego()
    {   
        
         SceneManager.LoadScene(0);
        
    }
}
