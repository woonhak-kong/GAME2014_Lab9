using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum AudioSourceType
{
    SOUND_FX,
    MUSIC
}


public class SoundManager : MonoBehaviour
{

    private List<AudioSource> audioSource;
    [SerializeField]
    private List<AudioClip> audioClips;

    private void Awake()
    {
        audioSource = GetComponents<AudioSource>().ToList();
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
        audioSource[(int)AudioSourceType.SOUND_FX].clip = audioClips[(int)sound];
        audioSource[(int)AudioSourceType.SOUND_FX].Play();
    }
}
