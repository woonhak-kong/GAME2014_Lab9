using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField]
    private List<AudioClip> audioClips;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioClips = new List<AudioClip>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InitializeSoundFX();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializeSoundFX()
    {
        audioClips.Add(Resources.Load<AudioClip>("Sounds/jump"));
        audioClips.Add(Resources.Load<AudioClip>("Sounds/hit"));
        audioClips.Add(Resources.Load<AudioClip>("Sounds/death"));
    }

    public void PlaySoundFX(SoundFX sound)
    {
        audioSource.clip = audioClips[(int)sound];
        audioSource.Play();
    }
}
