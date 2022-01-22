using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableDoor : MonoBehaviour
{
    public List<GameObject> doorPrefabs;

    private int currentDoor;

    public void HitDoor()
    {
        ShowNextDoor();
    }

    private void Start()
    {
        currentDoor = 0;
        ShowNextDoor();
    }

    private void ShowNextDoor()
    {
        if (currentDoor > doorPrefabs.Count - 1) return;
        doorPrefabs.ForEach(door => door.SetActive(false));
        doorPrefabs[currentDoor].SetActive(true);
        currentDoor++;
    }
}
