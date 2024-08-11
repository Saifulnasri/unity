using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerEvents : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public UnityEvent OnClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.Invoke();
        Destroy(this.gameObject);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        OnClick.Invoke();
        Destroy(this.gameObject);
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        OnClick.Invoke();
        Destroy(this.gameObject);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        OnClick.Invoke();
        Destroy(this.gameObject);
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        OnClick.Invoke();
        Destroy(this.gameObject);
    }
}
