using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBomba : MonoBehaviour
{

    private void Start()
    {
        BombaOlustur();
    }

    void BombaOlustur()
    {
        MaviBombaOlustur();
        MaviBombaOlustur2();
    }

    void MaviBombaOlustur() {

        MaviBomba _maviBombaOlustur = new MaviBomba();
        _maviBombaOlustur.BombaAdi = "MaviBomba";
        _maviBombaOlustur.BombaBuyuklugu = 100;
        _maviBombaOlustur.BombaID = 1;
        _maviBombaOlustur.BombaRengi = "Mavi";
        _maviBombaOlustur.EkstraHasar = true;

    }

    void MaviBombaOlustur2()
    {
        MaviBomba _maviBombaOlustur2 = new MaviBomba() { BombaAdi = "Mavi2", BombaBuyuklugu = 100, BombaID = 2, 
        BombaRengi = "Mavi", EkstraHasar = true, Hasari = 15 };
    }

}
