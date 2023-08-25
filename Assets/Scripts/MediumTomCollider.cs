using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumTomCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void MediumTom()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.MediumTom);
    }

    private void OnTriggerEnter(Collider other)
    {
        MediumTom();
    }
}
