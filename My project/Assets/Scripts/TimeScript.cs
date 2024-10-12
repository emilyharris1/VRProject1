using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    Vector3 prevPosition = new Vector3(0,0,0);

    void Update()
    {
        float dist = Vector3.Distance(prevPosition, transform.position);
        if (dist > 0.005f){
            Time.timeScale = 0.5f;
        }
        else{
            Time.timeScale = 0.2f;
        }
        prevPosition = transform.position;
    }
}



// xpos = current hand x position - old hand x position (something related to transform.position)
// ypos = current hand y position - old hand y position
// zpos = current hand z position - old hand z position
// if abs val xpos > 0, slow down time (Time.timeScale = 0.5f)
// if abs val ypos > 0, slow down time
// if abs val zpos > 0, slow down time
// hand is never fully still so I might want to change the value to be a bit more than 0
// else, don't change time (Time.timeScale = 1f)
