
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public Transform[] randomX;
    Vector3 whereToSpawn;
    public float spawnDelay;
    float nextSpawn = 0.0f;
    private Transform element;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            element = randomX[Random.Range(0, randomX.Length)];
            Instantiate(obj
                , element);
            
        }
    }
}
