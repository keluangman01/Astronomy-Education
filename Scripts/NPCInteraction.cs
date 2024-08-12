using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public AudioSource npcVoice;

    // Triggered when the player enters the collider
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the NPC voice when the player is near
            if (npcVoice != null && !npcVoice.isPlaying)
            {
                npcVoice.Play();
            }
        }
    }

    // Triggered when the player exits the collider
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Stop the NPC voice when the player moves away
            if (npcVoice != null && npcVoice.isPlaying)
            {
                npcVoice.Stop();
            }
        }
    }
}