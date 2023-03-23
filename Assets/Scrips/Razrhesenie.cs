using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Razrhesenie : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown  _dd;
    // Start is called before the first frame update
    void Start()
    {
        _dd.onValueChanged.AddListener(InputMenu);
    }

    // Update is called once per frame
    public void InputMenu(int value)
    {
        switch (value)
        {
            case 0:
                Screen.SetResolution(1920, 1080, true);
                Debug.Log("PIVO");
                break;
            case 1:
                Screen.SetResolution(1366, 768, true);
                break;
            case 2:
                Screen.SetResolution(2560, 1440, true);
                break;
            case 3:
                Screen.SetResolution(3840, 2160, true);
                break;
            case 4:
                Screen.SetResolution(800, 600, true);
                break;
        }
    }
}
