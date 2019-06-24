using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject prefabRed;
    public GameObject prefabBlue;
    public KeyCode bulletRedButton;
    // public KeyCode bulletBlueButton;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(bulletRedButton))
        {
            GameObject projectile = Instantiate(prefabRed, transform.position, Quaternion.identity);
            Destroy(projectile, 3);

        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectileBullet1 = Instantiate(prefabBlue, transform.position, Quaternion.identity);
            GameObject projectileBullet2 = Instantiate(prefabBlue, transform.position, Quaternion.identity);
            GameObject projectileBullet3 = Instantiate(prefabBlue, transform.position, Quaternion.identity);
            Destroy(projectileBullet1, 3);
            Destroy(projectileBullet2, 3);
            Destroy(projectileBullet3, 3);

        }
    }
}