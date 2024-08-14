using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public Transform[] shotSpawns;
    public float fireRate;
    public int fireLevel = 1;

    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {                                  // Tempo de jogo
        if (Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            // Atualizacao do nextFire
            nextFire = Time.time + fireRate;
            if(fireLevel >= 1)
            {
                Instantiate(bullet, shotSpawns[0].position, shotSpawns[0].rotation);
            }
            if(fireLevel >= 2)
            {
                Instantiate(bullet, shotSpawns[1].position, shotSpawns[1].rotation);
                Instantiate(bullet, shotSpawns[2].position, shotSpawns[2].rotation);
            }
            if(fireLevel >= 3)
            {
                Instantiate(bullet, shotSpawns[3].position, shotSpawns[3].rotation);
                Instantiate(bullet, shotSpawns[4].position, shotSpawns[4].rotation);
            }
        }
    }
}
