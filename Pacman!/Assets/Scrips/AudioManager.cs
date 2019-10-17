using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    float time = 0.0f;
    bool flag = false;
    public int nivel;
    // Start is called before the first frame update

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }



    void Start()
    {
        //Play("music");
        //Sound s = Array.Find(sounds, sound => sound.name == "music");
        //Debug.Log(s.clip.name);
        //nivel = 1;

    }

    void Update()
    {
        //time += Time.deltaTime;
        //Sound x = Array.Find(sounds, sound => sound.name == "music");
        //if (nivel == 2 && flag == false)
        //{
        //    Sound s = Array.Find(sounds, sound => sound.name == "music");
        //    Stop("music");
        //    Sound saux = Array.Find(sounds, sound => sound.name == "music2");

        //    s.clip = saux.clip;
        //    s.source.clip = saux.source.clip;
        //    Play("music");
        //    flag = true;
        //}
        //else if (nivel == 3 && flag == false)
        //{
        //    Sound s = Array.Find(sounds, sound => sound.name == "music");
        //    Stop("music");
        //    Sound saux = Array.Find(sounds, sound => sound.name == "music3");

        //    s.clip = saux.clip;
        //    s.source.clip = saux.source.clip;
        //    Play("music");
        //    flag = true;
        //}

        //if (!x.source.isPlaying)
        //{
        //    Debug.Log("fin del juego");
        //}

    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound " + name + " not found!");
            return;
        }
        s.source.Play();

    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound " + name + " not found!");
            return;
        }
        s.source.Stop();

    }

    public string GetClipName(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound " + name + " not found!");
            return "";
        }
        return s.clip.name;

    }

    public Sound GetAudio(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        return s;
    }
}