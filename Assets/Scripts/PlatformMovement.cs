using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMovement : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float duration = 2f;

    void Start()
    {
        transform.DOMove(endPosition, duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
