using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class OkularyVR : MonoBehaviour
{
    [Header("Efekty œwiata")]
    public GameObject efektFioletowy;
    public GameObject cyfryDrzew;

    private XRGrabInteractable grab;

    void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();

        grab.selectEntered.AddListener(OnGrab);
        grab.selectExited.AddListener(OnRelease);
    }

    void Start()
    {
        Debug.Log("[OKULARY] START");

        if (efektFioletowy != null)
            efektFioletowy.SetActive(false);

        if (cyfryDrzew != null)
            cyfryDrzew.SetActive(false);
    }

    // GRACZ TRZYMA OKULARY
    void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("[OKULARY] GRAB -> ON");

        if (efektFioletowy != null)
            efektFioletowy.SetActive(true);

        if (cyfryDrzew != null)
            cyfryDrzew.SetActive(true);
    }

    // GRACZ PUŒCI£ OKULARY
    void OnRelease(SelectExitEventArgs args)
    {
        Debug.Log("[OKULARY] RELEASE -> OFF");

        if (efektFioletowy != null)
            efektFioletowy.SetActive(false);

        if (cyfryDrzew != null)
            cyfryDrzew.SetActive(false);
    }
}