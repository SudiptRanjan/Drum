using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HiHatsCollider : MonoBehaviour
{
    Vector3 changedSize, origSize;
    // Start is called before the first frame update
    void Start()
    {
        origSize = new Vector3(0.3493346f, 0.00431057f, 0.3414555f);
        changedSize = new Vector3(0.2491419f, 0.00431057f, 0.3414555f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void HiHats()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.HiHats);
    }

    public void OnScale()
    {
        var tween = transform.DOScale(changedSize, 0.09f).OnComplete(() => { transform.DOScale(origSize, 0.09f); });
        if (tween.IsPlaying()) return;
        transform.DOKill();
    }

    private void OnTriggerEnter(Collider other)
    {
        HiHats();
        OnScale();
    }
}

//Imported Asset of drum and found some of the sounds of specific parts
 //Different sounds is being emitted from different parts  of drum using keys
 //When a collision takes place  the drum emitts sound 