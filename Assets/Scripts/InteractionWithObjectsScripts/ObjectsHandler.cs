using Services.InteractingWithObjectsServices;
using UnityEngine;

namespace InteractionWithObjectsScripts
{
    public class ObjectsHandler : MonoBehaviour
    {
        [SerializeField] private float rayDistance;
        [SerializeField] private Transform mainObjectsParent;
        
        private Camera _camera;
        private ActionTextHandler _actionTextHandler;
        private IObjectsFinder _objectsFinder;
        private IObjectsPicker _objectsPicker;
        private IObjectsThrower _objectsThrower;
        private Transform _objectTransform;

        private bool _isObjectPicked;

        private void Start()
        {
            _objectsFinder = new ObjectsFinderService();
            _objectsPicker = new ObjectsPickerService();
            _objectsThrower = new ObjectsThrowerService();
            _camera = Camera.main;
            _actionTextHandler = GetComponent<ActionTextHandler>();
        }

        private void Update()
        {
            if(!_isObjectPicked && !_objectsFinder.FindObject(_camera, rayDistance, out _objectTransform))
                _actionTextHandler.HideActionText();
            
            if (!_isObjectPicked)
            {
                _objectsPicker.PickObject(_camera, rayDistance, _objectTransform, _actionTextHandler,
                    ref _isObjectPicked, transform);
            }
            else if (_isObjectPicked)
            {
                Debug.Log($"{_objectTransform}");
                _objectsThrower.ThrowObject(_objectTransform, mainObjectsParent, _actionTextHandler,
                    ref _isObjectPicked);
            }
        }
    }
}