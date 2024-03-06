using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] 
    private AudioSource powerupAudioSource; // Set this in the inspector to the specific AudioSource you want to use for the powerup sound

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is the powerup
        if (other.CompareTag("PowerUp"))
        {
            Debug.Log("Player entered powerup trigger"); // Debug statement

            // Calculate pitch based on the size of the powerup
            float pitch = 1.0f / other.transform.localScale.magnitude;
            // Clamp the pitch between 0.1 and 2 to prevent it from being too low or too high
            pitch = Mathf.Clamp(pitch, 0.1f, 2f);

            powerupAudioSource.pitch = pitch;
            powerupAudioSource.Play();

            if (powerupAudioSource.isPlaying)
            {
                Debug.Log("Powerup sound is playing"); // Debug statement
            }
            else
            {
                Debug.Log("Powerup sound is not playing"); // Debug statement
            }
        }
    }
}