using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;

    private float numer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = spawnPoint.position;
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 100.0f);
        }
    }
}
