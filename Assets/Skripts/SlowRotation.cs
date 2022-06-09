using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowRotation : MonoBehaviour
{
    public Vector3      vect;
    public GameObject   Star;
    float angle = 360.0f;
    float time = 1.0f;
    Vector3 axis = Vector3.forward;
    void Update()
    {
        //Star.transform.RotateAround(Vector3.zero, axis, angle * Time.deltaTime / time);
        //Star.transform.Rotate(vect * Time.deltaTime * 50000, 5.0f);
        //Star.transform.Rotate(0, 0, 360.0f);
        transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 360);
    }
}
