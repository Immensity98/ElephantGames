using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwitchButtonCaller : MonoBehaviour, IPointerClickHandler
{
    public Button Button;

    public void OnPointerClick(PointerEventData eventData)
    {
        
        Button.gameObject.SetActive(true);
    }
}
