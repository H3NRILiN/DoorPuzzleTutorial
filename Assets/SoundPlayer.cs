using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {

    public Sounds[] m_SoundsSettings;

    Dictionary<string, AudioClip> m_AudioDic = new Dictionary<string, AudioClip>();

    AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();

        for (int i = 0; i < m_SoundsSettings.Length; i++)
        {
            m_AudioDic.Add(m_SoundsSettings[i].m_Name, m_SoundsSettings[i].m_AudioClip);
        }
    }

    public void PlaySound(string name)
    {

        m_AudioSource.clip = m_AudioDic[name];
        m_AudioSource.Play();
    }

}
[System.Serializable]
public class Sounds
{
    public string m_Name;
    public AudioClip m_AudioClip;
}
