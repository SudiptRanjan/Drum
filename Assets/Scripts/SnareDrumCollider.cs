using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareDrumCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SnareDrum()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.SnareDrum);
    }
    private void OnTriggerEnter(Collider other)
    {
        SnareDrum();
    }
}
