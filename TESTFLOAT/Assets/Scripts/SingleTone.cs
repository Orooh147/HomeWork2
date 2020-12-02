using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTone : MonoBehaviour
{
    private static SingleTone _instance;

    public static SingleTone Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("SingleTone");
                go.AddComponent<SingleTone>();
            }
            return _instance;
        }
    }

    public int Score { get; set; }
    public float Health { get; set; }
    public bool Isdead { get; set; }
    private void Awake()
    {
        _instance = this;

    }
}
