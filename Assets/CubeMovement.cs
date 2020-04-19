using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CubeMovement : MonoBehaviour

{
    public float maxSpeed = 10f;
    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public float move;
    public int Score = 0;
    public Text ScoreText;
    public Text WinText;
    public string levelToLoad;
    public GameObject BtnLeft;
    public GameObject BtnRight;
    public GameObject BtnJump;
    float PosBtnLeft;
    float PosBtnRight;
    float PosBtnJump;

    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
       
       
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "die collider")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (col.gameObject.tag == "star")
        {
            Destroy(col.gameObject);
            Score++;
        }
        if (col.gameObject.tag == "next level")
        {
           if (Score >= 1)
            {
                SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
            }
            
        }
    }
}
