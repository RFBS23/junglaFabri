using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Fabri;

    // Update is called once per frame
    void Update()
    {
        if (Fabri != null)
        {
            Vector3 position = transform.position;
            position.x = Fabri.transform.position.x;
            transform.position = position;
        }

    }
}
