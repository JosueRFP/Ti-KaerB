using TMPro;
using UnityEngine;

public class BoxCheck : MonoBehaviour
{
    [SerializeField] public int allMails;
    [SerializeField] GameObject winPainel;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (allMails == 5)
        {
            winPainel.SetActive(true);
            Time.captureDeltaTime = 0;
        }

       else 
       {
            winPainel.SetActive(false);
       }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            allMails++;
            Destroy(collision.gameObject);
        }

       
    }
}
