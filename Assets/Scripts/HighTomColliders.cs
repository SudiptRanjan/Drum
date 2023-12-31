using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HighTomColliders : MonoBehaviour
{
    Vector3 changedSize, origSize;
    Vector3 changedRotation, origRotation;
    // Start is called before the first frame update
    void Start()
    {
        origSize = new Vector3(1, 1, 1);
        changedSize = new Vector3(0.927269995f, 1, 0.885140002f);
        origRotation = new Vector3(357.69104f, 1.73200643f, 329.200195f);
        changedRotation = new Vector3(357.69104f, 1.73200631f, 313.573151f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HighTom();
            OnScale();
        }
    }
    private void HighTom()
    {
        AudioManager.instance.PlaySound(AudioManager.SoundName.HighTom);
    }
    private void OnScale()
    {
        var tween = transform.DOScale(changedSize, 0.09f).OnComplete(() => { transform.DOScale(origSize, 0.09f); });
        var tween2 = transform.DORotate(changedRotation, 0.09f).OnComplete(() => { transform.DORotate(origRotation, 0.09f); });

        if (tween.IsPlaying()) return;
        if (tween2.IsPlaying()) return;

        transform.DOKill();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    HighTom();
    //    OnScale();
    //}

    private void OnCollisionEnter(Collision collision)
    {
        //HighTom();
        //OnScale();
        Vector3 collisionForce = collision.impulse / Time.fixedDeltaTime;
        if (collisionForce.y >= 50)
        {
            //Debug.Log("collision at y position= =" + collisionForce.y);
            HighTom();
            OnScale();
        }
        Debug.Log("the contact force is==" + collisionForce);
    }
}
//Vector3(357.69104, 1.73200631, 313.573151)
