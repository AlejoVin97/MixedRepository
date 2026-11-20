using UnityEngine;

public class EnemigoRapido : Enemigo
{
    public override void Atacar(Jugador objetivo)
    {

        Avanzar(objetivo, 1.5f);
        Debug.Log(nombre + " ataca dos veces");
        objetivo.RecibirDanio(danio);
        objetivo.RecibirDanio(danio);

    }
}
