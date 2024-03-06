using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private AudioSource audioSource;
    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // If the character has moved and the audio is not currently playing
        if (transform.position != lastPosition && !audioSource.isPlaying)
        {
            // Randomly change the playback speed a small amount
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            // Randomly change the volume a small amount
            audioSource.volume = Random.Range(0.6f, 0.9f);
            // Play the step sound
            audioSource.Play();

            // Log a message to the console
            Debug.Log("Audio played with pitch " + audioSource.pitch + " and volume " + audioSource.volume);
        }
        // Update lastPosition for the next frame
        lastPosition = transform.position;
    }
}