using UnityEngine;

public class Brisi : MonoBehaviour
{
    public GameObject dudler;
    public GameObject platformaSkok;
    public GameObject platformPrefab;
    private GameObject myPlat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (Random.Range(1, 6) > 2)
            {
                myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.8f, 0.97f))), Quaternion.identity);

            }
            else
            {
                myPlat = (GameObject)Instantiate(platformaSkok, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.9f, 1f))), Quaternion.identity);

            }
        
       


        Destroy(collision.gameObject);
    }
}
