using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTomCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FloorTom()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.FloorTom);
    }
    private void OnTriggerEnter(Collider other)
    {
        FloorTom();
    }
}
