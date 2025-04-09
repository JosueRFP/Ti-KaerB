using UnityEngine;

public class Explosions : MonoBehaviour
{
    [SerializeField] GameObject bomb;


    private void Update()
    {
        OnMouseDown();
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bomb, mousePosition, Quaternion.identity);
        }
        
    }
     
    
}
