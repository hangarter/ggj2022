using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    public List<GameObject> spawnPositions;

    public int spawnDelayInSeconds = 10;
    public GameObject cat;
    public GameObject catIcon;
    public RageMeter rageMeter;

    private int currentSpawnPosition;
    private int maxSpawnPosition;

    public bool reduceRage;

    // Start is called before the first frame update
    void Start()
    {
        currentSpawnPosition = 0;
        maxSpawnPosition = spawnPositions.Count;

        StartCoroutine(Spawner());
        StartCoroutine(ReduceRage());
    }

    IEnumerator ReduceRage()
    {
        if (reduceRage)
        {
            rageMeter.rageFill.fillAmount = rageMeter.rageFill.fillAmount - 0.02f;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(ReduceRage());
    }

    IEnumerator Spawner()
    {
        if (!cat.activeSelf)
        {
            cat.transform.position = spawnPositions[currentSpawnPosition].transform.position;
            cat.SetActive(true);
            catIcon.SetActive(true);

            currentSpawnPosition++;

            if(currentSpawnPosition >= maxSpawnPosition)
            {
                currentSpawnPosition = 0;
            }
            reduceRage = true;
            Debug.Log(currentSpawnPosition);
        }
        yield return new WaitForSeconds(spawnDelayInSeconds);
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
