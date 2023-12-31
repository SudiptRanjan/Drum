using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MediumTomCollider : MonoBehaviour
{
    Vector3 changedSize, origSize;
    Vector3 changedRotation, origRotation;

    // Start is called before the first frame update
    void Start()
    {
        origSize = new Vector3(1f, 1f, 1f);
        changedSize = new Vector3(0.87598002f, 1f, 0.872590005f);
        origRotation = new Vector3(0, 0, 337.398224f);
        changedRotation = new Vector3(0, 0, 313.573151f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MediumTom();
            OnScale();
        }
    }
    private void MediumTom()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.MediumTom);
    }

    private void OnScale()
    {
        var tween = transform.DOScale(changedSize, 0.09f).OnComplete(() => { transform.DOScale(origSize, 0.09f); });
        var tween2 = transform.DORotate(changedRotation, 0.09f).OnComplete(() => { transform.DORotate(origRotation, 0.09f); });

        if (tween.IsPlaying()) return;
        if (tween2.IsPlaying()) return;

        transform.DOKill();
    }

    private void OnTriggerEnter(Collider other)
    {
        MediumTom();
        OnScale();
    }
}
//Vector3(1, 1, 1)
