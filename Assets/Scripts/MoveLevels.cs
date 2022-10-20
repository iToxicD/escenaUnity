using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLevels : MonoBehaviour
{
    public int scenes;

    private void OnTriggerEnter2D(Collider2D other) //Esto hacemos para que el personaje al colisionar salga de la escena
    {
        print("Saliendo de cueva.");

        if(other.tag == "Player")
        {
            print("Cambiando de mapa a" + scenes);
            SceneManager.LoadScene(scenes, LoadSceneMode.Single);
        }
    }
}
