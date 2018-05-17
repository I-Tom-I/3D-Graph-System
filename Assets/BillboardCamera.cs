using UnityEngine;
using System.Collections;

public class BillboardCamera : MonoBehaviour
{
    [Header("Set which camera the Sprite will billboard to")]
    public Camera camera;
    void Update()
    {
        transform.LookAt(transform.position + camera.transform.rotation * Vector3.forward, camera.transform.rotation * Vector3.up);
    }
}