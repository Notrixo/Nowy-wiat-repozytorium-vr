using TMPro;
using UnityEngine;

public class KeypadManager : MonoBehaviour
{
    public string poprawnyKod = "1234";
    private string wpisanyKod = "";

    public TextMeshPro kodText; // TO JEST INNE NI¯ UI

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

        // opcjonalnie:
        // kodText.text = new string('*', wpisanyKod.Length);
    }

    void SprawdzKod()
    {
        if (wpisanyKod == poprawnyKod)
        {
            Debug.Log("DOBRY KOD");
        }
        else
        {
            Debug.Log("Z£Y KOD");
        }

        wpisanyKod = "";
        AktualizujUI();
    }
}