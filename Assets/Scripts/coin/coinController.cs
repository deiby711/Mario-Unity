using UnityEngine;

public class coinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("Mario"))
            {
                GameEngine.instance.SumarMonedas();
                Destroy(gameObject);
                //oculatar game object
               // gameObject.SetActive(false);
                //Debug.Log("Si choco");
            }
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
}
