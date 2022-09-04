using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform vehicleStand;
    [SerializeField] private UIController uiController;

    [SerializeField] private float movementSpeed;
    private float xInput;

    private void Update()
    {
        if(uiController.IsDisplayOpen()) { return; }

        UserInput();
        Rotate();
        LookTowardsVehicle();
    }

    private void UserInput()
    {
        xInput = Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime;
    }

    private void LookTowardsVehicle()
    {
        Vector3 rotation = vehicleStand.position - transform.position;
        transform.rotation = Quaternion.LookRotation(rotation);
    }

    private void Rotate()
    {
        transform.transform.Translate(Vector3.right * xInput);
    }
}
