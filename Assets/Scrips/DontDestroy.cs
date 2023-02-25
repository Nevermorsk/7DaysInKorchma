using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public int counter;
    public int money;

    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DontDestroy");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
