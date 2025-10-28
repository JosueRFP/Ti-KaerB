using UnityEngine;

public class SendBoxController : MonoBehaviour
{
    [SerializeField] GameObject box;
    [SerializeField] Transform boxPosition;

    float nextToDrop;
    [SerializeField] ErrorTXT errorTXT;

    private void Start()
    {
        
    }

    void Update()
    {          
        OnMouseDown();
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(box, mousePosition, Quaternion.identity);
        }
        
    }
     


    
}
