using System;
using UnityEngine;

public class HorizontalMovingBehaviour : MonoBehaviour
{
    private float _currentTime;
    private const float HorizontalLength = 3f;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private Vector3 _position;

    private void Awake()
    {
        _position = transform.position;
        _startPosition = _position;
        _startPosition.x -= HorizontalLength;
        _endPosition = _position;
        _endPosition.x += HorizontalLength;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, HorizontalLength) / HorizontalLength;
        transform.position = Vector3.Lerp(_startPosition,
            _endPosition, progress);
        if (_currentTime >= HorizontalLength)
        {
            _currentTime = -HorizontalLength;
        }
    }
}