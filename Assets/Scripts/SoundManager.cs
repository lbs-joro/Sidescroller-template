using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    SoundEffect[] soundEffects;

    Dictionary<string, GameObject> soundEffectMap;

    private void Start()
    {
        if(instance != null)
        {
            Debug.LogError("You can only have one sound manager in scene!");
        }
        instance = this;

        soundEffectMap = new Dictionary<string, GameObject>();

        foreach (SoundEffect se in soundEffects)
        {
            soundEffectMap.Add(se.soundName, se.soundPrefab);
        }
    }
    public void PlaySoundEffect(string soundEffectName)
    {
        Instantiate(soundEffectMap[soundEffectName]);
    }

}

[System.Serializable]
public struct SoundEffect
{
    public string soundName;
    public GameObject soundPrefab;

}