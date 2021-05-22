using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Noise_trigger : MonoBehaviour
{
    private AudioSource a_source;
    public AudioClip[] a_clips;

    // Start is called before the first frame update
    void Start()
    {
        a_source = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayRandomSound();
    }
    public void PlayRandomSound()
    {
        int selection = Random.Range(1, a_clips.Length);
        a_source.PlayOneShot(a_clips[selection]);
    }



}
