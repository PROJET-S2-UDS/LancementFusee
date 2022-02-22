using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Autofocus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool focusModeSet = VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!focusModeSet)
        {
            Debug.Log("Failed to set focus mode" + focusModeSet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
