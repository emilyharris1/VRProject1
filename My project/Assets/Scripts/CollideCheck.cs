using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if ((other.gameObject.CompareTag("Target")) || (other.gameObject.CompareTag("EnemyHitBox"))){
            Destroy(other.gameObject.transform.parent.gameObject);
        }
}
}
