using UnityEngine;

public class LopataKopanie : MonoBehaviour
{
    public float zasieg = 0.25f;
    public float cooldown = 0.5f;

    private float ostatniCzas;

    void Start()
    {
        Debug.Log("ŁOPATA VR AKTYWNA");
    }

    void Update()
    {
        Debug.Log("SPRAWDZAM...");

        if (Time.time - ostatniCzas < cooldown)
        {
            Debug.Log("COOLDOWN");
            return;
        }

        // 🔥 tylko JEDNA definicja zmiennej
        Collider[] trafienia = Physics.OverlapSphere(transform.position, zasieg);

        Debug.Log("ZNALEZIONO OBIEKTÓW: " + trafienia.Length);

        foreach (var col in trafienia)
        {
            Debug.Log("DOTYKAM: " + col.name);

            PunktKopania punkt = col.GetComponent<PunktKopania>();

            if (punkt != null)
            {
                Debug.Log(">>> ZNALEZIONO PUNKT KOPANIA <<<");

                punkt.Wykop(transform.position);

                ostatniCzas = Time.time;

                Debug.Log("WYKOP WYWOŁANY");

                return;
            }
            else
            {
                Debug.Log("to NIE jest PunktKopania");
            }
        }
    }
}