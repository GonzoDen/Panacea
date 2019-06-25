using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject prefabRed;
    public GameObject prefabBlue;
    public KeyCode bulletRedButton;
    // public KeyCode bulletBlueButton;
    ParticleSystem ps;
    ParticleSystem.EmitParams emitParams;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        // emitParams = new ParticleSystem.EmitParams();
    }

    // Update is called once per frame
    void Update()
    {
        // ps.Emit(emitParams, 50);
        
        if (Input.GetKeyDown(bulletRedButton))
        {
            GameObject projectile = Instantiate(prefabRed, transform.position, Quaternion.identity);
            ps.Play();
            Destroy(projectile, 3);

        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectileBullet1 = Instantiate(prefabBlue, transform.position, Quaternion.identity);
            GameObject projectileBullet2 = Instantiate(prefabBlue, transform.position, Quaternion.identity);
            GameObject projectileBullet3 = Instantiate(prefabBlue, transform.position, Quaternion.identity);
            ps.Play();
            Destroy(projectileBullet1, 3);
            Destroy(projectileBullet2, 3);
            Destroy(projectileBullet3, 3);

        }

        
    }
}