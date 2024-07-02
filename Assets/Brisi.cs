using UnityEngine;

public class Brisi : MonoBehaviour
{
    public GameObject dudler;
    public GameObject platformaSkok;
    public GameObject platformPrefab;
   // private GameObject myPlat;

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
        // Check if the collision object is valid
        if (collision == null || collision.gameObject == null)
        {
            return;
        }

        // Check if the collision object name starts with "platforma"
        if (collision.gameObject.name.StartsWith("platforma"))
        {
            HandlePlatformCollision(collision);
        }
        // Check if the collision object name starts with "Odskok"
        else if (collision.gameObject.name.StartsWith("Odskok"))
        {
            HandleOdskokCollision(collision);
        }
    }

    private void HandlePlatformCollision(Collider2D collision)
    {
        if (collision == null || collision.gameObject == null)
        {
            return;
        }

        if (Random.Range(1, 6) == 1)
        {
            Instantiate(platformaSkok, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f)), Quaternion.identity);
            Destroy(collision.gameObject);
        }
        else
        {
            if (collision != null && collision.gameObject != null)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f));
            }
        }
    }

    private void HandleOdskokCollision(Collider2D collision)
    {
        if (collision == null || collision.gameObject == null)
        {
            return;
        }

        if (Random.Range(1, 6) == 1)
        {
            if (collision != null && collision.gameObject != null)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f));
            }
        }
        else
        {
            Instantiate(platformPrefab, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f)), Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision == null || collision.gameObject == null)
    //    {
    //        return;
    //    }

    //    if (collision.gameObject.name.StartsWith("platforma"))
    //    {
    //        if (Random.Range(1, 6) == 1)
    //        {

    //            Debug.LogWarning("palo se");
    //            // Instantiate a new platform and destroy the collided one safely
    //            Instantiate(platformaSkok, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f)), Quaternion.identity);
    //            Destroy(collision.gameObject);
    //        }
    //        else
    //        {
    //            // Move the collided platform to a new position
    //            collision.gameObject.transform.position = new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f));
    //        }
    //    }
    //    else if (collision.gameObject.name.StartsWith("Odskok"))
    //    {
    //        Debug.LogWarning("uso");
    //        if (Random.Range(1, 6) == 1)
    //        {
    //            // Move the collided platform to a new position
    //            collision.gameObject.transform.position = new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f));
    //        }
    //        else
    //        {
    //            // Instantiate a new platform and destroy the collided one safely
    //            Instantiate(platformPrefab, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + Random.Range(0.9f, 1f)), Quaternion.identity);
    //            Destroy(collision.gameObject);
    //        }
    //    }

        //if (collision.gameObject.name.StartsWith("platforma"))
        //{
        //   
        //    if (Random.Range(1, 6) == 1)
        //    {
        //        try
        //        {
        //            if(collision.gameObject != null)
        //            {
        //                Instantiate(platformaSkok, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.9f, 1f))), Quaternion.identity);

        //                Destroy(collision.gameObject);
        //            }


        //        }
        //        catch (MissingReferenceException e)
        //        {

        //            Debug.LogError("Caught a MissingReferenceException3: " + e.Message);

        //        }

        //    }
        //    else
        //    {
        //        try
        //        {
        //            collision.gameObject.transform.position = new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.9f, 1f)));

        //        }
        //        catch (MissingReferenceException e)
        //        {

        //            Debug.LogError("Caught a MissingReferenceException4: " + e.Message);

        //        }

        //    }

        //}
        //else if (collision.gameObject!=null && collision.gameObject.name.StartsWith("Odskok"))
        //{
        //    if (Random.Range(1, 6) == 1)
        //    {
        //        try
        //        {
        //            collision.gameObject.transform.position = new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.9f, 1f)));

        //        }
        //        catch (MissingReferenceException e)
        //        {
        //            Debug.LogError("Caught a MissingReferenceException1: " + e.Message);
        //        }


        //    }
        //    else
        //    {
        //        try
        //        {
        //            Instantiate(platformPrefab, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.9f, 1f))), Quaternion.identity);
        //            Destroy(collision.gameObject);
        //        }
        //        catch (MissingReferenceException e)
        //        {

        //            Debug.LogError("Caught a MissingReferenceException2: " + e.Message);
        //        }


        //    }



        //if (Random.Range(1, 6) > 2)
        //{
        //    myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.8f, 0.97f))), Quaternion.identity);

        //}
        //else
        //{
        //    myPlat = (GameObject)Instantiate(platformaSkok, new Vector2(Random.Range(-2.78f, 2.78f), dudler.transform.position.y + (Random.Range(0.9f, 1f))), Quaternion.identity);

        //}




        //Destroy(collision.gameObject);
    //}
}
