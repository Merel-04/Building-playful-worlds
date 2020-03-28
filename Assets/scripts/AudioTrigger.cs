using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource source;
    public float chimeVolume;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayAudio(AudioClip clip)
    {
        source.clip = clip;
        source.PlayOneShot(clip);

        if (clip.name == "chimes")
        {
            source.volume = chimeVolume;
        }
        else
        {
            source.volume = 1;
        }
    }

    public void SpawnParticles(GameObject particles)
    {
        Instantiate(particles, particles.transform.position, Quaternion.identity);
    }
}
