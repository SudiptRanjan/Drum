using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideCymbalCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RideCymbal()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.RideCymbal);
    }

    private void OnTriggerEnter(Collider other)
    {
        RideCymbal();
    }
}
