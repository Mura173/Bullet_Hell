using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float FireRate;
    public Transform[] shotSpawns;

    // Start is called before the first frame update
    void Start()
    {
        // Passar a funcao como string, tempo e tempo de repeticao
        InvokeRepeating("Fire", FireRate, FireRate);
    }

    void Fire()
    {
        for (int i = 0; i < shotSpawns.Length; i++)
        {
            Instantiate(bullet, shotSpawns[i].position, shotSpawns[i].rotation);
        }
    }
}
