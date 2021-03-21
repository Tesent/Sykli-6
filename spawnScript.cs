using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    
    public Transform[] spawnPoints;
    public GameObject targets;
    // Start is called before the first frame update
    void Start()
    {
        //Start spawning
        StartCoroutine(StartSpawning());
    }

   IEnumerator StartSpawning()
    {
        //Wait for 4 second before spawning
        yield return new WaitForSeconds(4);

        //Randomise the positions of the 5 spawns
        var ranPosX = Random.Range(-5, 5);
        var ranPosY = Random.Range(-5, 5);
        var ranPosZ = Random.Range(0, 5);
        //Take randomly one of the 5 spwans
        var ran = Random.Range(0, 5);
        //Set new positions to the spawn
        spawnPoints[ran].position = new Vector3(spawnPoints[ran].position.x + ranPosX, spawnPoints[ran].position.y + ranPosY, spawnPoints[ran].position.z + ranPosZ);
        
        //Spawn target
        Instantiate(targets, spawnPoints[ran].position, Quaternion.Euler(0,90,0));
        
        //Repeat
        StartCoroutine(StartSpawning());
    }
    
}
