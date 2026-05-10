using UnityEngine;
using System.Collections.Generic;

public class KodManager : MonoBehaviour
{
    public List<int> kod = new List<int>();
    public int maxCyfry = 4;

    public void DodajCyfre(int cyfra)
    {
        if (kod.Count >= maxCyfry) return;

        kod.Add(cyfra);
        Debug.Log("Kod: " + string.Join("", kod));
    }

    public void ResetujKod()
    {
        kod.Clear();
    }
}