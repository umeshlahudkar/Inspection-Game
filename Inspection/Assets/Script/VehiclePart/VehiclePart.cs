using UnityEngine;

public class VehiclePart : MonoBehaviour, IInspectable
{
    [SerializeField] private VehiclePartSO partSO;

    public VehiclePartSO GetPartDetails()
    {
        return partSO;
    }
}
