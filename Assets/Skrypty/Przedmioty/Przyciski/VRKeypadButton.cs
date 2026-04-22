using UnityEngine;

public class VRKeypadButton : MonoBehaviour
{
    public int liczba; // np. 1,2,3...
    public KeypadManager keypad;

    public void Nacisnij()
    {
        keypad.DodajCyfre(liczba);
    }
}