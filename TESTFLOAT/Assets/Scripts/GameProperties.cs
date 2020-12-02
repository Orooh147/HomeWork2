using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProperties : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SingleTone.Instance.Score = 10;
        SingleTone.Instance.Health = 100f;
        SingleTone.Instance.Isdead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
