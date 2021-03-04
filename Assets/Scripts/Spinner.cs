using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xRotate = 0;
    [SerializeField] private float yRotate = 0.01f;
    [SerializeField] private float zRotate = 0;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
