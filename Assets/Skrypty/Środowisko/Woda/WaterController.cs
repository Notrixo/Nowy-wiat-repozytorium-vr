using UnityEngine;

public class WaterController : MonoBehaviour
{
    [Header("Woda")]
    public Renderer waterRenderer;
    public Collider waterCollider;

    [Header("Znikanie")]
    public float fadeSpeed = 0.5f;

    private bool draining = false;

    void Update()
    {
        if (!draining) return;

        Color col = waterRenderer.material.color;
        col.a -= fadeSpeed * Time.deltaTime;
        waterRenderer.material.color = col;

        if (col.a <= 0f)
        {
            waterCollider.enabled = false;
            gameObject.SetActive(false);
        }
    }

    public void DrainWater()
    {
        draining = true;
    }
}