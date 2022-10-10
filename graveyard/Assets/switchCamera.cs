using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
    public List<Camera> Cameras;
    // Start is called before the first frame update
    private void Start()
    {
        EnableCamera(0);
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableCamera(0); // press 1 for first person
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableCamera(1); // press 2 for third person
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            EnableCamera(2); // press 3 for ortho
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            EnableCamera(3); // press 4 for moving
        }
    }

    private void EnableCamera(int n) {
        Cameras.ForEach(cam => cam.enabled = false);
        Cameras[n].enabled = true;
    }
}
