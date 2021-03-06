using UnityEngine;
using System.Collections;

//Got the help from http://answers.unity3d.com/questions/11314/audio-or-music-to-continue-playing-between-scene-c.html

public class ResetIgnore : MonoBehaviour {

    private static ResetIgnore instance = null;
    public static ResetIgnore Instance
    {
        get { return instance; }
    }


    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    //What this basically does is: Check for an existing instance, if there already is an instances, 
    //then destroy self - if not, store this is instance 
    //(so anyone who's coming later will destroy themselves).

}

