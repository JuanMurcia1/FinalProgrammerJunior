using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("RespawnFood",1.0f,1.0f);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RespawnFood(){
        Vector3 spawnLocation = new Vector3(Random.Range(-7.01f, 8.31f), 9.64f, -3.74f);
        int RandomFood= Random.Range(0,objectPrefabs.Length);
        Instantiate(objectPrefabs[RandomFood], spawnLocation, objectPrefabs[RandomFood].transform.rotation);
    }

    



    
}
 