using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseScript : MonoBehaviour {

    public GameObject theRoof;
    public GameObject[] secondFloor;
    public GameObject[] theLights;
    public GameObject directionalLight;

    public static houseScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
