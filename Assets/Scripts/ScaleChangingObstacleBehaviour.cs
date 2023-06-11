using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScaleChangingObstacleBehaviour : MonoBehaviour
    {
        private Vector3 _startScale;
        private Vector3 _endScale;
        private const float ScaleChanging = 2f;
        private const float OnScaleDuration = 2f;
        private float _scaleTime = 2f;

        private void Awake()
        {
            var localScale = transform.localScale;
            _startScale = localScale;
            _endScale = localScale * ScaleChanging;
        }

        private void Update()
        {
            _scaleTime += Time.deltaTime;
            var progress = Mathf.PingPong(_scaleTime, OnScaleDuration) / OnScaleDuration;
            transform.localScale = Vector3.Lerp(_startScale, _endScale, progress);
            if (_scaleTime >= OnScaleDuration)
            {
                _scaleTime = -OnScaleDuration;
            }
        }
    }
}