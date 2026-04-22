using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class UiManager : MonoBehaviour
{

    public TMP_Text _scoreText;
    public TMP_Text _lifeText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score" + GameEngine.instance.monedas;
        _lifeText.text = "Vidas" + GameEngine.instance.vidas;
    }
}
