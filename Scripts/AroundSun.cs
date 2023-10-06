using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundSun : MonoBehaviour
{
    [SerializeField]
    Transform sun;
    [SerializeField, Range(0.1f, 1f)]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.position, Vector3.forward, speed);
    }
}
