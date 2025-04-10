using UnityEngine;

public class SendBoxController : MonoBehaviour
{
    [SerializeField] GameObject box;
    public Transform boxPosition;
    
    private float nextToDrop;

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
