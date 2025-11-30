using UnityEngine;

public class CollisionEfect : MonoBehaviour
{
    [SerializeField] GameObject efect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        efect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            efect.SetActive(true);
        }
    }


}
