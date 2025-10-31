using UnityEngine;
using UnityEngine.Events;

public class SendBoxController : MonoBehaviour
{
    [SerializeField] GameObject box;
    [SerializeField] Transform boxPosition;

    float dropRate;
    [SerializeField] UnityEvent OnDropBox;
     

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
            OnDropBox.Invoke();
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(box, mousePosition, Quaternion.identity);
           
        }
        
    }
     


    
}
