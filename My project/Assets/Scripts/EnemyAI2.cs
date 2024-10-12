using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI2 : MonoBehaviour
{
    [SerializeField]
    private float move_speed = 10f;
    private GameObject playerTarget;

    void Update()
    {
        //only move forward when we have a player target
        if(playerTarget != null){
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * move_speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other){
        playerTarget = other.gameObject;
    }
}
