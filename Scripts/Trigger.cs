using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] bool destroyOnTriggerEnter;
    [SerializeField] string tagFilter;
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;

    [Header("Additional Actions")]
    [SerializeField] AudioClip soundToPlay;
    [SerializeField] GameObject doorToAppear;

    private void OnTriggerEnter(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

        if (destroyOnTriggerEnter)
        {
            Destroy(gameObject);
        }

        PlaySoundAndAppearDoor();
        onTriggerEnter?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerExit?.Invoke();
    }

    private void PlaySoundAndAppearDoor()
    {
        if (soundToPlay != null)
        {
            AudioSource.PlayClipAtPoint(soundToPlay, transform.position);
        }

        if (doorToAppear != null)
        {
            doorToAppear.SetActive(true);
        }
    }
}
