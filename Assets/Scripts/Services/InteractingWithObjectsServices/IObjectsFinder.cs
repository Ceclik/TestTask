using UnityEngine;

namespace Services.InteractingWithObjectsServices
{
    public interface IObjectsFinder
    {
        public bool FindObject(Camera camera, float rayDistance, out Transform objectTransform);
    }
}