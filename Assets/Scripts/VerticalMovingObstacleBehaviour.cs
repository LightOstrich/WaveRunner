using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class VerticalMovingObstacleBehaviour : MonoBehaviour
    {
        private Vector3 _start;
        private Vector3 _end;
        private float _verticalMovementTime;
        private const float VerticalMoving = 5f;
        private const float VerticalMovementDuration = 2f;

        private void Awake()
        {
            var position = transform.position;
            _start = position;
            _end = position;
            _end.y -= VerticalMoving;
        }

        private void Update()
        {
            _verticalMovementTime += Time.deltaTime;
            var progress = Mathf.PingPong(_verticalMovementTime, VerticalMovementDuration) / VerticalMovementDuration;
            transform.position = Vector3.Lerp(_start, _end, progress);
            if (_verticalMovementTime >= VerticalMovementDuration)
            {
                _verticalMovementTime = -VerticalMovementDuration;
            }
        }
    }
}