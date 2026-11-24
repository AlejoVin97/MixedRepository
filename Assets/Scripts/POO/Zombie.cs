using UnityEngine;

public class Zombie : Enemigo
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Atacar(Jugador objetivo)
    {
        Avanzar(objetivo, 0.5f);
        Debug.Log(nombre + " muerde: " + danio);
        objetivo.RecibirDanio(danio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
