using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class mainMenu : MonoBehaviour {

    public void changeLevel(string name)
    {
        if (name == "World")
            SceneManager.LoadScene(1);

        else if (name == "Quit")
            Application.Quit();

            
    }

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
