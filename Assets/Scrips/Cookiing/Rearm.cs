using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rearm : MonoBehaviour
{
    [SerializeField] private Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(Fun);
    }
    void Fun(){
        SceneManager.LoadScene("Day 1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
