using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public int health;

    public AudioSource audioSource { get; private set; }

    public int totalHealth = 100;
    public int damagePerHit = 30;

    public AudioClip breakNoise;

    // Start is called before the first frame update
    void Start()
    {
        health = totalHealth;
        audioSource = Camera.main.gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(breakNoise);

        particleSystem.Stop();
        particleSystem.Play();

        health -= damagePerHit;
        Debug.Log(health);
        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
