using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stepSize;
    
    private Vector3 _targetPosition;
    private float _maxLeftDistance = -7;
    private float _maxRightDistance = 7;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if(transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }

    public void TryMoveLeft()
    {
        if (_targetPosition.x > _maxLeftDistance)
            SetNextPosition(-_stepSize);
    }

    public void TryMoveRight()
    {
        if (_targetPosition.x < _maxRightDistance)
            SetNextPosition(_stepSize);
    }

    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x + stepSize, _targetPosition.y);
    }
}
