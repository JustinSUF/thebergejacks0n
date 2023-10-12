using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    public AudioSource audioSource;
    public float fadeDuration = 2.0f;
    public AudioClip sound;

    private float initialVolume;

    void Start()
    {
        // Store the initial volume of the audio source
        if (audioSource != null)
            initialVolume = audioSource.volume;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the Circle Collider was triggered
        if (other.CompareTag("Player"))
        {
            // Play the sound
            if (audioSource != null && sound != null)
            {
                audioSource.clip = sound;
                audioSource.Play();
            }
            // Start fading the item
            StartCoroutine(FadeOut());
        }
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime = 35;

            yield return null;
        }
        Destroy(gameObject);
    }
}