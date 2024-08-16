using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateMin, rotateMax;

    private float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = Random.Range(rotateMin, rotateMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
    }
}
