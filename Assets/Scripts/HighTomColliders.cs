using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HighTomColliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void HighTom()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.HighTom);
    }

    private void OnTriggerEnter(Collider other)
    {
        HighTom();
    }
}
