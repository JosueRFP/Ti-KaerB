using TMPro;
using UnityEngine;

public class SendBoxTxt : MonoBehaviour
{
    [SerializeField] public float startBoxs;
    [SerializeField] TextMeshProUGUI deliveryBoxs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startBoxs = 0f;
    }

    // Update is called once per frame
    void Update()
    {
       deliveryBoxs.text = "Deliverd:" + startBoxs;
    }


   public void UpdateBoxCount()
    {
        startBoxs++;
    }
}
