using UnityEngine;

public class AxeHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dotkn¹³em: " + other.name);

        TreeCut drzewo = other.GetComponent<TreeCut>();

        if (drzewo != null)
        {
            drzewo.Uderz();
        }
    }
}