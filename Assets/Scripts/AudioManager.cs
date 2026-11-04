using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource mainSource;
    [SerializeField] AudioSource drumSource;
    [SerializeField] AudioSource leadSource;
    [SerializeField] AudioClip[] audioClips;

    void Start()
    {
        mainSource.PlayOneShot(audioClips[0]);
        drumSource.PlayOneShot(audioClips[1]);
        leadSource.PlayOneShot(audioClips[2]);
    }
}
