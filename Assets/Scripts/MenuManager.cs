using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jugar()
    {
        SceneManager.LoadScene("NivelUno");
        //SaveSystem.GuardarJuego("NivelUno");
        GameEngine.instance.canvas .gameObject.SetActive(true);
    }

    public void salir()
    {
        Application.Quit();
    }
}
