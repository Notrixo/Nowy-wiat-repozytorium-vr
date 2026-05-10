using UnityEngine;

public class OkularyVR : MonoBehaviour
{
    public bool aktywne;

    public Transform headMount;
    public GameObject efektFioletowy;

    private bool zalozone;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        aktywne = false;
        zalozone = false;

        if (efektFioletowy != null)
            efektFioletowy.SetActive(false);

        Debug.Log("[OKULARY] START -> aktywne = false");
    }

    void Update()
    {
        Debug.Log("[OKULARY] Update -> aktywne = " + aktywne + " | zalozone = " + zalozone);
    }

    public void ZalozOkulary()
    {
        Debug.Log("[OKULARY] ZALOZONO");

        zalozone = true;
        aktywne = true;

        transform.SetParent(headMount);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        if (rb != null)
        {
            rb.isKinematic = true;
            rb.useGravity = false;
        }

        if (efektFioletowy != null)
            efektFioletowy.SetActive(true);

        Debug.Log("[OKULARY] EFECT ON");
    }

    public void ZdejmijOkulary()
    {
        Debug.Log("[OKULARY] ZDJETO");

        zalozone = false;
        aktywne = false;

        transform.SetParent(null);

        if (rb != null)
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }

        if (efektFioletowy != null)
            efektFioletowy.SetActive(false);

        Debug.Log("[OKULARY] EFECT OFF");
    }
}