using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VisionFeriante : MonoBehaviour
{

    public string tag;

       // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            Debug.Log("¡El feriante ha detectado a nuestro protagonista!");
        }
    }
}
