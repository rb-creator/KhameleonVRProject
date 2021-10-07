using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wolf3D.ReadyPlayerMe.AvatarSDK;

public class VoiceActivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VoiceHandler>().PlayCurrentAudioClip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
