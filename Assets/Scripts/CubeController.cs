using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HearXR;

public class CubeController : MonoBehaviour
{
    void Start()
    {
        HeadphoneMotion.Init();

        if (HeadphoneMotion.IsHeadphoneMotionAvailable())
        {
            HeadphoneMotion.OnHeadRotationQuaternion += HandleHeadRotationQuaternion;
            HeadphoneMotion.StartTracking();
        }
    }

    private void HandleHeadRotationQuaternion(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
}
