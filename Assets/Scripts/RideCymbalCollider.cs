using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RideCymbalCollider : MonoBehaviour
{
    Vector3 changedSize, origSize;
    // Start is called before the first frame update
    void Start()
    {
        origSize = new Vector3(0f, 0f, 0f);
        changedSize = new Vector3(334.368103f, 12.13762f, 333.564972f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            RideCymbal();
            OnScale();
        }
    }
    private void RideCymbal()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.RideCymbal);
    }
    private void OnScale()
    {
        //var tween = transform.DORotate(changedSize, 0.09f).OnComplete(() => { transform.DORotate(origSize, 0.09f); });
        var tween = transform.DOShakeRotation(2f, 10, 10, 0, fadeOut: true, ShakeRandomnessMode.Harmonic);

        if (tween.IsPlaying()) return;
        transform.DOKill();
    }

    private void OnTriggerEnter(Collider other)
    {
        RideCymbal();
        OnScale();
    }
}
