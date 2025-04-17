using System;
using TMPro;
using UnityEngine;

public class BoxesManeger : MonoBehaviour
{
    [SerializeField] GameObject boxe;
    [SerializeField] TextMeshProUGUI boxCouter;
    [SerializeField] Collider checkCollider;
    [SerializeField] Transform check;
    [SerializeField] bool oneBox;

    [SerializeField] LayerMask layerMask;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void  Start()
    {
        check = GetComponentInChildren<Transform>();
        oneBox = true;
    }

    private void Update()
    {
        // checkCollider = Physics.OverlapBox(check.position, check.localScale, );
    }


}
