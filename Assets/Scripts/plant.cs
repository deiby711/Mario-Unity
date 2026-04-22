using UnityEngine;

public class plant : MonoBehaviour
{

    private bool yaGolpeo = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (yaGolpeo) return;

        bool isPlayer = collision.CompareTag("Mario") 
                        || collision.CompareTag("Player") 
                        || collision.GetComponentInParent<MarioControl>() != null;

        if (isPlayer)
        {
            yaGolpeo = true;
            if (GameEngine.instance != null) GameEngine.instance.RestarVidas();
            else Debug.LogWarning("GameEngine.instance is null");
            Destroy(gameObject);
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
