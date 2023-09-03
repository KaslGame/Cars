using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _hightCamera;

    private void Update()
    {
        if (_target != null)
        {
            Vector3 target = new Vector3(_target.transform.position.x, _target.transform.position.y + _hightCamera, -10);

            transform.position = Vector3.Lerp(transform.position, target, _moveSpeed * Time.deltaTime);
        }
    }
}
