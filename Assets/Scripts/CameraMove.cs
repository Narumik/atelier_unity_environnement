using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Range(0.0f, 5.0f)]
    public float vitesseAvance = 2;
    [Range(0.0f, 360.0f)]
    public float vitesseTourne = 20;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * vitesseAvance;
        transform.rotation = Quaternion.AngleAxis(-vitesseTourne * Time.deltaTime, Vector3.up) * transform.rotation;
    }
}
