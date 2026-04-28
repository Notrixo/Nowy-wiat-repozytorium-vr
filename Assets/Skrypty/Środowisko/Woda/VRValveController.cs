using UnityEngine;

public class VRValveController : MonoBehaviour
{
    [Header("Wody")]
    public WaterController river;
    public WaterController waterfall;

    [Header("Zawór")]
    public Transform valveHandle;

    [Header("Obrót")]
    public float requiredRotation = 360f;

    private float lastAngle;
    private float totalRotation;
    private bool activated;

    void Start()
    {
        lastAngle = GetAngle();
    }

    void Update()
    {
        if (activated) return;

        float currentAngle = GetAngle();
        float delta = Mathf.DeltaAngle(lastAngle, currentAngle);

        totalRotation += Mathf.Abs(delta);
        lastAngle = currentAngle;

        if (totalRotation >= requiredRotation)
        {
            Activate();
        }
    }

    float GetAngle()
    {
        return valveHandle.eulerAngles.y;
    }

    void Activate()
    {
        activated = true;

        river.DrainWater();
        waterfall.DrainWater();
    }
}