using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public int counter;
    public int money;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
