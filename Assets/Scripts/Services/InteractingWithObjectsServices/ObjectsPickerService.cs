﻿using InteractionWithObjectsScripts;
using UnityEngine;

namespace Services.InteractingWithObjectsServices
{
    public class ObjectsPickerService : IObjectsPicker
    {
        private readonly IObjectsFinder _objectsFinderService = new ObjectsFinderService();

        public void PickObject(Camera camera, float rayDistance, Transform objectTransform,
            ActionTextHandler actionTextHandler, ref bool isObjectPicked, Transform characterTransform)
        {
            if (_objectsFinderService.FindObject(camera, rayDistance, out objectTransform))
            {
                if (!actionTextHandler.IsTextShown)
                    actionTextHandler.ShowActionText(isObjectPicked);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    objectTransform.SetParent(characterTransform);
                    objectTransform.position = new Vector3(objectTransform.position.x, camera.transform.position.y,
                        objectTransform.position.z);
                    isObjectPicked = true;
                    actionTextHandler.ShowActionText(isObjectPicked);
                }
            }
        }
    }
}