using UnityEngine;

// Plays short sound effects. Music is a separate AudioSource with Loop + Play On Awake.
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource sfxSource;

    [Header("Clips")]
    public AudioClip pickupClip;
    public AudioClip deliverClip;
    public AudioClip wrongClip;
    public AudioClip winClip;

    void Awake()
    {
        Instance = this;
    }

    public void Play(AudioClip clip)
    {
        if (clip != null) sfxSource.PlayOneShot(clip);
    }
}
