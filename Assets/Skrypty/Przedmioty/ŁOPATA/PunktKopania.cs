using UnityEngine;

public class PunktKopania : MonoBehaviour
{
    public GameObject skrzynkaPrefab;
    public GameObject prefabDziury;

    private bool czyWykopane = false;

    public void Wykop(Vector3 startPosition)
    {
        Debug.Log("WYKOP START");

        if (czyWykopane) return;
        czyWykopane = true;

        // 🔥 RAYCAST W DÓŁ (PEWNA POZYCJA NA ZIEMI)
        RaycastHit hit;

        if (Physics.Raycast(startPosition + Vector3.up, Vector3.down, out hit, 5f))
        {
            Vector3 punkt = hit.point;

            Debug.Log("TRAFFIONA ZIEMIA: " + hit.collider.name);

            // 🕳️ DZIURA (lekko nad ziemią)
            if (prefabDziury != null)
            {
                GameObject dziura = Instantiate(
                    prefabDziury,
                    punkt + hit.normal * 0.01f,
                    Quaternion.Euler(90, 0, 0)
                );

                Debug.Log("DZIURA OK");
            }

            // 📦 SKRZYNKA (na ziemi)
            if (skrzynkaPrefab != null)
            {
                GameObject skrzynka = Instantiate(
                    skrzynkaPrefab,
                    punkt + Vector3.up * 0.1f,
                    Quaternion.identity
                );

                Debug.Log("SKRZYNKA OK");
            }
        }
        else
        {
            Debug.LogError("NIE TRAFIONO ZIEMI (raycast)");
        }
    }
}