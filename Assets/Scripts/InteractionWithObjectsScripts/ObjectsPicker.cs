using System;
using Services.InteractingWithObjectsServices;
using UnityEngine;

namespace InteractionWithObjectsScripts
{
    public class ObjectsPicker : MonoBehaviour
    {
        [SerializeField] private float rayDistance;
        
        private Camera _camera;
        private ActionTextHandler _actionTextHandler;
        private IObjectsFinder _objectsFinderService;
        private IObjectsPicker _objectsPickerService;
        private Transform _objectTransform;

        private bool _isObjectPicked;

        private void Start()
        {
            _objectsFinderService = new ObjectsFinderService();
            _objectsPickerService = new ObjectsPickerService();
            _camera = Camera.main;
            _actionTextHandler = GetComponent<ActionTextHandler>();
        }

        private void Update()
        {
            if (!_isObjectPicked)
            {
                _objectsPickerService.PickObject(_camera, rayDistance, _objectTransform, _actionTextHandler,
                    ref _isObjectPicked, transform);
            }
            else if (_isObjectPicked)
            {
                
            }
        }
    }
}