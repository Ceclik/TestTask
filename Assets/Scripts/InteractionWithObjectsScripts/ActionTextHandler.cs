using Services.InteractingWithObjectsServices;
using TMPro;
using UnityEngine;

namespace InteractionWithObjectsScripts
{
    public class ActionTextHandler : MonoBehaviour
    {
        
        [SerializeField] private TextMeshProUGUI actionText;

        public TextMeshProUGUI ActionText => actionText;
        
        private Camera _camera;
        private IActionTextHandler _actionTextHandler;

        public bool IsTextShown { get; private set; }

        private void Start()
        {
            _camera = Camera.main;
            _actionTextHandler = new ActionTextHandlingService();
        }

        public void ShowActionText(bool isObjectPicked)
        {
            _actionTextHandler.HandleActionText(actionText, isObjectPicked);
            IsTextShown = true;
        }
    }
}