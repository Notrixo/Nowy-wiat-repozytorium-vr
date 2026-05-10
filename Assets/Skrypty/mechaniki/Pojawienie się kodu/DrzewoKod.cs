using UnityEngine;
using TMPro;

public class DrzewoKod : MonoBehaviour
{
    public int cyfra;

    public TextMeshPro tekst;
    public OkularyVR okulary;

    public float zasieg = 3f;

    Transform gracz;

    void Start()
    {
        gracz = GameObject.FindGameObjectWithTag("Player").transform;

        tekst.text = "START";
        tekst.gameObject.SetActive(false);

        Debug.Log("[DRZEWO] START cyfra = " + cyfra);
    }

    void Update()
    {
        if (okulary == null)
        {
            Debug.LogError("[DRZEWO] BRAK OKULARÓW (NULL)");
            return;
        }

        float dist = Vector3.Distance(transform.position, gracz.position);

        Debug.Log("[DRZEWO] aktywne=" + okulary.aktywne + " dystans=" + dist);

        bool widac = okulary.aktywne && dist <= zasieg;

        if (widac)
        {
            tekst.gameObject.SetActive(true);
            tekst.text = cyfra.ToString();

            Debug.Log("[DRZEWO] POKAZ CYFRE " + cyfra);
        }
        else
        {
            tekst.gameObject.SetActive(false);
        }
    }
}