using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class LoopAnimation : MonoBehaviour
{
    private void Update()
    {
        PlayAnimation();
    }

    public void PlayAnimation()
    {
        transform.Rotate(0, 0, 1);
    }
}
