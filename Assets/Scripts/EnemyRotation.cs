using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyRotation : MonoBehaviour
{
    public Transform player;
    public float duration = 0.5f;

    void Update()
    {
        transform.DORotateQuaternion(Quaternion.LookRotation(player.position - transform.position), duration).SetEase(Ease.InOutSine);
    }
}
