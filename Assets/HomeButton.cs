using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HomeButton : MonoBehaviour,  IPointerUpHandler
{ 
    public GameObject HomeBtn;
    public string levelToLoad = "ARComponents";
    public void Start() { }
    public void Update() { }

    public void OnPointerUp(PointerEventData eventData)
    {
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
    }
}
