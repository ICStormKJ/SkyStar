using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    [SerializeField]
    GameObject planetPrefab;
    [SerializeField]
    Material mat;

    [SerializeField, Range(1, 20)]
    int planetScale;
    [SerializeField, Range(1, 10)]
    int speed;
    
    public int numPlanets = 4;
    public float spacing = 3.0f;
    GameObject[] planets;
    // Start is called before the first frame update
    void Start()
    {
        var scale = Vector3.one * planetScale;
        var position = Vector3.zero;
        planets = new GameObject[numPlanets];
        for (int i = 0; i < planets.Length; i++){
            GameObject pl = planets[i] = Instantiate(planetPrefab);
            pl.transform.localPosition = new Vector3(position.x + 20 + (i*spacing), 0f, 0f);
            pl.transform.localScale = scale;
            pl.GetComponent<Renderer>().material = mat;
        }
    }

    // Update is called once per frame
    float i = 0.1f;
    void Update()
    {
        foreach (GameObject p in planets){
            p.transform.RotateAround(transform.position, Vector3.right, i);
            i += 0.1f;
        }
        
        i = speed * 0.1f;
    }
}
