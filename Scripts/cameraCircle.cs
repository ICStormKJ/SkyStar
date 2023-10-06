using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCircle : MonoBehaviour
{
    [SerializeField]
    Transform sun;
    // Start is called before the first frame update
    Vector3 pivot;
    void Start()
    {
        pivot = sun.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot, Vector3.up, 0.03f);
    }
}
