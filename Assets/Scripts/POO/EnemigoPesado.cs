using UnityEngine;

public class EnemigoPesado : Enemigo
{
    public override void Atacar(Jugador objetivo)
    {

        Avanzar(objetivo, 0.2f);
        Debug.Log(nombre + " ataca fuerte");
        objetivo.RecibirDanio(danio*2);
        
    }
}
