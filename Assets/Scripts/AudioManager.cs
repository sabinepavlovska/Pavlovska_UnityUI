using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Clips")]
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private AudioClip characterSound;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void PlayClick()
    {
        sfxSource.PlayOneShot(clickSound);
    }

    public void PlayCharacterSound()
    {
        sfxSource.PlayOneShot(characterSound);
    }
}