using UnityEngine;

public class HammerHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BridgeBuilder builder = other.GetComponent<BridgeBuilder>();

        if (builder != null)
        {
            builder.Zbuduj();
        }
    }
}