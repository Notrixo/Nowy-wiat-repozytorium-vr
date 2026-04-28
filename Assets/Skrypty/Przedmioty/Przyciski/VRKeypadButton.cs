using UnityEngine;

public class VRKeypadButton : MonoBehaviour
{
    public int liczba;
    public KeypadManager keypad;

    public void Nacisnij()
    {
        keypad.DodajCyfre(liczba);
    }
}