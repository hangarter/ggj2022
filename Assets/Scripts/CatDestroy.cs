using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDestroy : MonoBehaviour
{
    public CatSpawner catSpawner;
    public GameObject catIcon;

    private void OnTriggerEnter(Collider other)
    {
        catSpawner.reduceRage = false;
        gameObject.SetActive(false);
        catIcon.SetActive(false);
    }
}
