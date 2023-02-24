using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CupDragAndDrop : MonoBehaviour,IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    [SerializeField] private Sprite rightSprite;
    [SerializeField] private Sprite leftSprite;
    [SerializeField] private Sprite filledSprite;

    private Vector2 startPosition;
    private Vector2 barrelPosition;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        startPosition = rectTransform.anchoredPosition;
        barrelPosition = GameObject.FindWithTag("Barrel").GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if (rectTransform.anchoredPosition != barrelPosition) {
            rectTransform.anchoredPosition = startPosition;

            GetComponent<Image>().sprite = rightSprite;
            rectTransform.sizeDelta = new Vector2(95, 57);
        } else
        {
            GetComponent<Image>().sprite = leftSprite;
            rectTransform.sizeDelta = new Vector2(60, 67);
        }
    }
}
