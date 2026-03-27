using UnityEngine;

public class plant : MonoBehaviour
{

    private bool yaGolpeo = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (yaGolpeo) return;

        if (collision.transform.root.CompareTag("Mario"))
        {
            yaGolpeo = true;

            GameEngine.instance.RestarVidas();

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
