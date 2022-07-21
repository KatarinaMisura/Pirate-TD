using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{

    [SerializeField]
    private float speed = 1;
    [SerializeField]
    private float maxSpeed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = (speed + Mathf.Sin(Time.time) * float.MaxValue) * Vector3.one;
    }
}
