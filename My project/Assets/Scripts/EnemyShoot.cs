using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    public Transform playerTransform;
    public GameObject BulletTemplate;
    public float shootPower = 500f;
    public float shootInterval = 8f;
    private float shootTimer;

    // Start is called before the first frame update
    void Start()
    {
        shootTimer = shootInterval;
    }

    void Update() {
        shootTimer -= Time.deltaTime;
        float dist = Vector3.Distance(transform.position, playerTransform.position);
        if (shootTimer < 0 && dist < 4f) {   
            Shoot();
            shootTimer = shootInterval;
        }

        transform.LookAt(playerTransform.position);
    }

    void Shoot() {
        GameObject newBullet = Instantiate(BulletTemplate, transform.position+transform.forward*0.6f, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
    }

}
