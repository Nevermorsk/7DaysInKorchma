using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BarrelDragAndDrop : MonoBehaviour, IDropHandler
{
    [SerializeField] private float delay;

    [HideInInspector] public static bool isDraggable = true;
    [HideInInspector] public static bool isFilled = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (isFilled) { return; }
        if(eventData.pointerDrag != null)
        {
            isDraggable = false;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        FillCup();
    }

    private void FillCup()
    {
        isDraggable = true;
        isFilled = true;
    }
}
