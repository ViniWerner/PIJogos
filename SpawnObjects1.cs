using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects1 : MonoBehaviour
{

    public Transform[] spawPoints;
    public GameObject[] itens;
    float minHeigth;
    float maxHeigth;
    int randomSpawnPoint;
    int randomItem;
    public static bool spawnAllowed;

    // Use this for initialization
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAItens", 10f, 1.9f);

    }

    void SpawnAItens()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawPoints.Length);
            randomItem = Random.Range(0, itens.Length);
            Instantiate(itens[randomItem], spawPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
