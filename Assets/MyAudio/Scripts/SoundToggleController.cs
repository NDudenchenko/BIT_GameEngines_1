using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundToggleController : MonoBehaviour
{
    public KeyCode keyCodeForActivation;
    public AudioSource audioSourceInthis;
    // Start is called before the first frame update
    void Start()
    {
        audioSourceInthis = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCodeForActivation))
        {
            if (audioSourceInthis.isPlaying)
            {
                audioSourceInthis.Pause();
            }
            else
            {
                audioSourceInthis.Play();
            }
        }
    }
}
