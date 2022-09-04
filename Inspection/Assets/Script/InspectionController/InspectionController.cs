using UnityEngine;

public class InspectionController : MonoBehaviour
{
    [SerializeField] private UIController uiController;
    [SerializeField] private Camera mainCamera;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && !uiController.IsDisplayOpen())
        {
            InspectPart();
        }
    }

    private void InspectPart()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo))
        {
            IInspectable inspectable = hitInfo.collider.gameObject.GetComponent<IInspectable>();
            if(inspectable != null)
            {
                VehiclePartSO data = inspectable.GetPartDetails();
                uiController.DisplayInfo(data);
            }
        }
    }
}
