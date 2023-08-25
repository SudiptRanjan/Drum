using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCymbalolliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CrashCymbal()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.CrashCymbal);
    }

    private void OnTriggerEnter(Collider other)
    {
        CrashCymbal();
    }
}
