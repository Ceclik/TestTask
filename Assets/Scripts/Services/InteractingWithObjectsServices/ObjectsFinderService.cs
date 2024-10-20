using UnityEngine;

namespace Services.InteractingWithObjectsServices
{
    public class ObjectsFinderService : IObjectsFinder
    {
        public bool FindObject(Camera camera, float rayDistance, out Transform objectTransform)
        {
            Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                if (hit.collider.CompareTag("Object"))
                {
                    objectTransform = hit.collider.transform;
                    return true;
                }

                objectTransform = null;
                return false;
            }

            objectTransform = null;
            return false;
        }
    }
}