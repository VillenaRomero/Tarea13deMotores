using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CollectibleScale : MonoBehaviour
{
    public float scaleFactor = 1.5f;
    public float duration = 0.2f;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "1")
        {
            transform.DOScale(scaleFactor, duration).SetEase(Ease.InOutSine);
        }
    }
}
