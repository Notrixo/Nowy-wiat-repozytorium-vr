using UnityEngine;

public class SkrzynkaOtwieranie : MonoBehaviour
{
    public Animator animator;
    public bool czyOtwarta = false;

    public void Otworz()
    {
        if (czyOtwarta) return;

        czyOtwarta = true;
        animator.SetTrigger("Open");
    }
}