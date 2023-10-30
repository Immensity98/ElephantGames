using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class OnClickAnimation : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.GetComponent<SpriteRenderer>().DOColor(Color.blue, 5f);
    }
}
