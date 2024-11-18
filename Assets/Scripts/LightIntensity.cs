using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering;

public class LightIntensity : MonoBehaviour
{
    public Light light;
    public float targetIntensity = 2f;
    public float duration = 1f;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "1")
        {
            light.DOIntensity(targetIntensity, duration).SetEase(Ease.InOutSine);
        }
    }
}