using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class VRDoor : MonoBehaviour
{
    public Transform drzwiRoot;
    public Transform punktZawiasu;
    public Transform punktOtwarcia;
    public XRGrabInteractable grab;

    public float katOtwarcia = 90f;

    void Update()
    {
        if (!grab.isSelected)
            return;

        Vector3 kierunek = (punktOtwarcia.position - punktZawiasu.position).normalized;

        float t = Vector3.Dot(drzwiRoot.position - punktZawiasu.position, kierunek);
        t = Mathf.Clamp01(t);

        drzwiRoot.localRotation = Quaternion.Euler(0, t * katOtwarcia, 0);
    }
}