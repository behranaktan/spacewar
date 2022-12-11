using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField]
    AudioClip asteroidPatlama;

    [SerializeField]
    AudioClip gemiPatlama;

    [SerializeField]
    AudioClip ates;


    AudioSource audiosource;



    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }


    public void asteroidexpo()
    {
        audiosource.PlayOneShot(asteroidPatlama,0.3f);
    }

    public void shipexpo()
    {
        audiosource.PlayOneShot(gemiPatlama,0.3f);
    }

    public void fire()
    {
        audiosource.PlayOneShot(ates,0.3f);
    }
}
