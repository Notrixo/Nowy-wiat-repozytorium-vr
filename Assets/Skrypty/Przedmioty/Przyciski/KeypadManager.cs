using TMPro;
using UnityEngine;

public class KeypadManager : MonoBehaviour
{
    public string poprawnyKod = "1234";
    private string wpisanyKod = "";

    public TextMeshPro kodText;
    public Animator drzwiAnimator;

    public void DodajCyfre(int cyfra)
    {
        wpisanyKod += cyfra.ToString();
        AktualizujUI();

        if (wpisanyKod.Length >= poprawnyKod.Length)
        {
            SprawdzKod();
        }
    }

    void AktualizujUI()
    {
        kodText.text = wpisanyKod;
    }

    void SprawdzKod()
    {
        if (wpisanyKod == poprawnyKod)
        {
            Debug.Log("DOBRY KOD");
            drzwiAnimator.SetBool("Open", true);
        }
        else
        {
            Debug.Log("Z£Y KOD");
        }

        wpisanyKod = "";
        AktualizujUI();
    }
}