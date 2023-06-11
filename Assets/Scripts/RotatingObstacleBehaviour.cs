using UnityEngine;

namespace DefaultNamespace
{
    public class RotatingObstacleBehaviour : MonoBehaviour
    {
        private const float RotationSpeed = 10f;


        private void Update()
        {
            transform.Rotate(0, 0, RotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}