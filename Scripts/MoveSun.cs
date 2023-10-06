using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSun : MonoBehaviour
{
    [SerializeField]
    Transform start, end;


    // Start is called before the first frame update

    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, Mathf.PingPong(Time.time/5, 1));
        
    }
}
