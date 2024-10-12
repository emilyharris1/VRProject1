using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public InputActionReference triggerLeft;
    public InputActionReference triggerRight;

    void Update()
    {
        GameObject[] enemiesLeft = GameObject.FindGameObjectsWithTag("EnemyHitBox");
        if (enemiesLeft.Length < 1){
            SceneManager.LoadScene("WinScreen");
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Bullet")){
            SceneManager.LoadScene("LoseScreen");
        }
    }
}

