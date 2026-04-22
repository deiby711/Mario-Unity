using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public  static GameEngine instance;
    public int monedas;
    public int vidas = 3;
    public Canvas canvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            vidas = 3;
        }
        else
        {
            //Destroy(instance);
        }
        canvas.gameObject.SetActive(false);
    }
    
    
    
    
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void SumarMonedas()
    {
        monedas++;
        //Debug.Log(monedas);
    
    }
    public void RestarVidas()
    {
        // Restar una vida si hay al menos una disponible.
        if (vidas > 0)
        {
            vidas--;
        }

        // Asegurarse de que no sea negativo
        vidas = Mathf.Max(vidas, 0);

        Debug.Log("Vidas restantes: " + vidas);

        if (vidas == 0)
        {
            Debug.Log("GAME OVER");
            if (canvas != null)
            {
                canvas.gameObject.SetActive(true);
            }
        }
    }
}
