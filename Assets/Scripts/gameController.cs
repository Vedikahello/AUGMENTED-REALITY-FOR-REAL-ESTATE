using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	

    public void changeScene(string name)
    {
        SceneManager.LoadSceneAsync(name);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void hideObj(string name)
    {
        GameObject.Find(name).SetActive(false);
    }

}
