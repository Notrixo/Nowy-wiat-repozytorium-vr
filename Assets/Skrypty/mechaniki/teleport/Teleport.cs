using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform punktDocelowy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = punktDocelowy.position;
        }
    }
}