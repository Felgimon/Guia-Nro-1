using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Horizontal;
    [SerializeField] private float Vertical;
    void Start()
    {
        Horizontal = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
