using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    private Transform bullet;

    [SerializeField]
    private Rigidbody2D bulletRb;

    public float bulletSpeed;

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
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Transform bulletTransform = Instantiate(bullet, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

            bulletRb.velocity = Vector2.up * bulletSpeed;
        }
    }
}
