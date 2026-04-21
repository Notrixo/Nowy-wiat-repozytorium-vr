using UnityEngine;

public class GrassSpawner : MonoBehaviour
{
    public GameObject grassPrefab; // prefab trawy
    public int ilosc = 500; // ile trawy
    public Vector3 rozmiarMapy = new Vector3(106, 10, 106); // rozmiar mapy

    void Start()
    {
        for (int i = 0; i < ilosc; i++)
        {
            // losowa pozycja X Z
            float x = Random.Range(-rozmiarMapy.x / 2, rozmiarMapy.x / 2);
            float z = Random.Range(-rozmiarMapy.z / 2, rozmiarMapy.z / 2);

            Vector3 start = new Vector3(x, 10, z);

            RaycastHit hit;

            // strza³ w dó³ ¿eby znaleŸæ ziemiê
            if (Physics.Raycast(start, Vector3.down, out hit, 20))
            {
                Instantiate(grassPrefab, hit.point, Quaternion.identity, transform);
            }
        }
    }
}