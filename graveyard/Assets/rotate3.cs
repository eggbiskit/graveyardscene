using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate3 : MonoBehaviour
{

    // add options to the inspector
    public float xAngle, yAngle, zAngle;

    // Update is called once per frame
    void Update()
    {
        // Rotate(Vector3 eulers, Space relativeTo = Space.Self);
        transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

        // transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
}
