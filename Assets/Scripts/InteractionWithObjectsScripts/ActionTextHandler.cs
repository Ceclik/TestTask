using TMPro;
using UnityEngine;

namespace InteractionWithObjectsScripts
{
    public class ActionTextHandler : MonoBehaviour
    {
        [SerializeField] private float rayDistance;
        [SerializeField] private TextMeshProUGUI actionText;

        public TextMeshProUGUI ActionText => actionText;
        
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void FixedUpdate()
        {
            Ray ray = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                if (hit.collider.CompareTag("Object"))
                {
                    actionText.text = "Press 'F' to pick an object";
                    actionText.gameObject.SetActive(true);
                }
                else 
                    actionText.gameObject.SetActive(false);
            }
            
        }
    }
}