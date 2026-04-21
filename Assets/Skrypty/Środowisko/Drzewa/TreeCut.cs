using UnityEngine;

public class TreeCut : MonoBehaviour
{
    public int maxUderzen = 5;
    private int aktualneUderzenia = 0;

    public GameObject klodaPrefab;

    public void Uderz()
    {
        aktualneUderzenia++;

        Debug.Log("Uderzenie: " + aktualneUderzenia);

        if (aktualneUderzenia >= maxUderzen)
        {
            ZniszczDrzewo();
        }
    }

    void ZniszczDrzewo()
    {
        Instantiate(klodaPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}