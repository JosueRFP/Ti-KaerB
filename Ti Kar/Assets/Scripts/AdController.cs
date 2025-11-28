using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class AdController : MonoBehaviour
{
    Button adBTN;
    Button closeADBTN;
    [SerializeField] GameObject[] ads;

    private void Start()
    {
        closeADBTN = GetComponent<Button>();
        adBTN = GetComponent<Button>();
        adBTN.clicked += ShowAd;
    }

     public  void ShowAd()
     {
        ads[Random.Range(0, ads.Length)].SetActive(true);
     }

}
