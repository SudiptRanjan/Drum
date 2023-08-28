using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HighTomColliders : MonoBehaviour
{
    Vector3 changedSize, origSize;

    // Start is called before the first frame update
    void Start()
    {
        origSize = new Vector3(1, 1, 1);
        changedSize = new Vector3(0.927269995f, 1, 0.885140002f);
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
        if (tween.IsPlaying()) return;
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
