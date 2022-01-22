using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableDoor : MonoBehaviour
{
    public GameObject youWinText;
    public List<GameObject> doorPrefabs;
    public AudioClip crackingNoise;
    public AudioClip breakingNoise;

    private AudioSource audioSource;
    private int currentDoor;

    public void HitDoor()
    {
        if (LastHit())
        {
            PlayBreakDoorNoise();
            gameObject.SetActive(false);
            youWinText.SetActive(true);
        }
        else
        {
            PlayCrackingNoise();
        }
        ShowNextDoor();
    }

    private void PlayCrackingNoise()
    {
        if (currentDoor > 0)
        {
            audioSource.PlayOneShot(crackingNoise);
        }
    }

    private void PlayBreakDoorNoise()
    {
        audioSource.PlayOneShot(breakingNoise);
    }

    private bool LastHit()
    {
        return currentDoor >= doorPrefabs.Count;
    }

    private void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
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
