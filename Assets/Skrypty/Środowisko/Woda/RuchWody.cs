using UnityEngine;

public class RuchWody : MonoBehaviour
{
    public float predkoscX = 0.2f;
    public float predkoscY = 0.0f;

    private Renderer rend;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        offset.x += predkoscX * Time.deltaTime;
        offset.y += predkoscY * Time.deltaTime;

        rend.material.SetTextureOffset("_BaseMap", offset);
    }
}