using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   public GameObject ENGINEER;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = ENGINEER.transform.position.x;
        transform.position = position;
    }
}
