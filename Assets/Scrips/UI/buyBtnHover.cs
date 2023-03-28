using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class buyBtnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private string itemName;
    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.FindGameObjectWithTag("indicator").GetComponent<TextMeshProUGUI>().text = itemName;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject.FindGameObjectWithTag("indicator").GetComponent<TextMeshProUGUI>().text = string.Empty;
    }
}
