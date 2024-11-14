using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioType{
    BGM,
    SFX
}

[System.Serializable]
public class AudioObject{
    public string id;
    public AudioType type;
    public AudioClip clip;
}

public class AudioManager : MonoBehaviour
{

    private static AudioManager _instance;
    public static AudioManager instance{
        get{
            if(_instance == null){
                _instance = GameObject.FindObjectOfType<AudioManager>();
            }
            return _instance;
        }
    }

    public AudioSource audioSourceBGM;
    public AudioSource audioSourceSFX;

    public List<AudioObject> audioObjects;

    public void PlayAudio(AudioType _type, string _id){
        switch(_type){
            case AudioType.BGM:
                audioSourceBGM.clip = SearchAudioClip(_id);
                audioSourceBGM.Play();
                break;
            case AudioType.SFX:
                audioSourceSFX.clip = SearchAudioClip(_id);
                audioSourceSFX.Play();
                break;
        }
    }

    private AudioClip SearchAudioClip(string _id){
        AudioClip clip = null;

        for(int i = 0; i < audioObjects.Count; i++){
            if(audioObjects[i].id == _id){
                clip = audioObjects[i].clip;
            }
        }

        return clip;
    }

}
