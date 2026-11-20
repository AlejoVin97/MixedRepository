using UnityEngine;
using UnityEngine.InputSystem;
public class GestorCombate : MonoBehaviour
{
    public Jugador jugador;
    public Enemigo[] enemigos;
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            foreach (Enemigo enemigo in enemigos)
            {
                enemigo.Atacar(jugador);
            }
        }
    }
}
