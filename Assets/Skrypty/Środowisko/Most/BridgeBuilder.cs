using Mono.Cecil;
using UnityEngine;

public class BridgeBuilder : MonoBehaviour
{
    public int wymaganeDrewno = 3;
    public int wymaganyKamien = 2;

    private int aktualneDrewno = 0;
    private int aktualnyKamien = 0;

    public GameObject mostPrefab;

    public void DodajDrewno()
    {
        aktualneDrewno++;
        Debug.Log("Drewno: " + aktualneDrewno);
    }

    public void DodajKamien()
    {
        aktualnyKamien++;
        Debug.Log("Kamien: " + aktualnyKamien);
    }

    public bool CzyMoznaBudowac()
    {
        return aktualneDrewno >= wymaganeDrewno &&
               aktualnyKamien >= wymaganyKamien;
    }

    public void Zbuduj()
    {
        if (!CzyMoznaBudowac())
        {
            Debug.Log("Za ma³o surowców!");
            return;
        }

        Instantiate(mostPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        ResourceType res = other.GetComponent<ResourceType>();

        if (res != null)
        {
            if (res.typ == ResourceType.Typ.Drewno)
                DodajDrewno();

            if (res.typ == ResourceType.Typ.Kamien)
                DodajKamien();

            Destroy(other.gameObject);
        }
    }
}