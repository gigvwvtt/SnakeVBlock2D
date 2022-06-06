using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerWall : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private void FixedUpdate()
    {
        transform.position = GetTargetPosition();
    }
    private Vector3 GetTargetPosition()
    {
        return new Vector3(transform.position.x, _camera.transform.position.y, transform.position.z);
    }
}
