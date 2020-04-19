using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Btn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject character;
    public Rigidbody2D rb;
    public int direction; // 1 - right 0 - left
    public void OnPointerDown (PointerEventData eventData)
    {

    }
    public void OnPointerUp(PointerEventData eventData)
    {       
        if (direction == 1) rb.AddForce(new Vector2(100f, 400f));
        else if (direction == 0) rb.AddForce(new Vector2(-100f, 400f));
        // Debug.Log("prygayu");
    }
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("character");
        rb = character.GetComponent<Rigidbody2D>();
        

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
