using TMPro;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public  static GameEngine instance;
    public TMP_Text coinText;

    public int monedas;
    public int vidas = 5;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            //Destroy(instance);
        }
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
        coinText.text = "Monedas: " + monedas;
    }

    public void RestarVidas()
    {
        if (vidas > 0)
        {
            vidas--;
            Debug.Log("Vidas restantes: " + vidas);

            if (vidas == 0)
            {
                Debug.Log("GAME OVER");
            }
        }
    }
}
