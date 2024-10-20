using System.Collections;
using UnityEngine;

namespace MovingScripts
{
    public class DoorsRotator : MonoBehaviour
    {
        [SerializeField] private float rotationDuration;
        [SerializeField] private float openingDelay;

        [Space(10)] [SerializeField] private Transform leftDoor;
        [SerializeField] private Transform rightDoor;

        private float _elapsedTime;

        private bool _isOpening;
        private Quaternion _leftDoorEndRotation;
        private Quaternion _leftDoorStartRotation;
        private Quaternion _rightDoorEndRotation;
        private Quaternion _rightDoorStartRotation;

        private void Start()
        {
            StartCoroutine(StartOpenDors());

            _leftDoorStartRotation = leftDoor.rotation;
            _rightDoorStartRotation = rightDoor.rotation;

            _leftDoorEndRotation = _leftDoorStartRotation * Quaternion.Euler(0f, 0, 120.0f);
            _rightDoorEndRotation =
                _rightDoorStartRotation * Quaternion.Euler(0f, 0f, -120.0f); // Противоположное направление
        }

        private void FixedUpdate()
        {
            if (_isOpening)
            {
                _elapsedTime += Time.deltaTime;
                leftDoor.rotation = Quaternion.Lerp(_leftDoorStartRotation, _leftDoorEndRotation,
                    _elapsedTime / rotationDuration);
                rightDoor.rotation =
                    Quaternion.Lerp(_rightDoorStartRotation, _rightDoorEndRotation, _elapsedTime / rotationDuration);
                if (_elapsedTime >= rotationDuration) _isOpening = false;
            }
        }

        private void OpenDoors()
        {
            _elapsedTime = 0f;
            _isOpening = true;
        }

        private IEnumerator StartOpenDors()
        {
            yield return new WaitForSeconds(openingDelay);
            OpenDoors();
            _isOpening = true;
        }
    }
}