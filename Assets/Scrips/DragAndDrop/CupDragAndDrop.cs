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
    private GameObject CupHint;

    private bool _isFilled;
    private bool _isDraggable;

    void Update()
    {
        _isFilled = BarrelDragAndDrop.isFilled;
        _isDraggable = BarrelDragAndDrop.isDraggable;

        if (_isFilled)
        {
            GetComponent<Image>().sprite = filledSprite;
        } else
        {
            GetComponent<Image>().sprite = rightSprite;
        }
    }

    private void Awake()
    {
        _isFilled = BarrelDragAndDrop.isFilled;
        _isDraggable = BarrelDragAndDrop.isDraggable;

        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        startPosition = rectTransform.anchoredPosition;
        barrelPosition = GameObject.FindWithTag("Barrel").GetComponent<RectTransform>().anchoredPosition;
        CupHint = GameObject.FindWithTag("CupHint");
        CupHint.SetActive(false);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!_isDraggable) { return; }
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        if (_isFilled) { return; }
        CupHint.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!_isDraggable) { return; }
        rectTransform.anchoredPosition += new Vector2(eventData.delta.x, eventData.delta.y);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        CupHint.SetActive(false);
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if (rectTransform.anchoredPosition != barrelPosition) {
            rectTransform.anchoredPosition = startPosition;

            GetComponent<Image>().sprite = rightSprite;
        } else
        {
            GetComponent<Image>().sprite = leftSprite;
        }
    }
}
