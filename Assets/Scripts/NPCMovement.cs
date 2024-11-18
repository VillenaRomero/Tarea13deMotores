using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NPCMovement : MonoBehaviour
{
    public Vector3 targetPosition;
    public float duration = 1f;

    void Start()
    {
        transform.DOMove(targetPosition, duration).SetEase(Ease.InOutSine);
    }
}
