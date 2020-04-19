using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;


public class start_game : MonoBehaviour, IVirtualButtonEventHandler

{

    public string scene_to_load;
    public GameObject launch_button;
    // public GameObject box;

    public void OnButtonPressed(VirtualButtonBehaviour virtual_button)
    {
        // SceneManager.LoadScene(scene_to_load, LoadSceneMode.Single);
        Debug.Log("been pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour virtual_button)
    {
        SceneManager.LoadScene(scene_to_load, LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        launch_button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

}
