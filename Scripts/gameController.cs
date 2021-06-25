using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {
	public static string currentSelectedCar = "myLamboConvert";

	// Use this for initialization
	void Start () {
		
	}
	public void showNewCar(string nextCar){
		GameObject.Find (colourSwitcher.instance.getCurrentTracked ().name + "/activeitems/" + gameController.currentSelectedCar).SetActive(false);
		currentSelectedCar = nextCar;
		GameObject.Find (colourSwitcher.instance.getCurrentTracked ().name + "/activeitems/" + gameController.currentSelectedCar).SetActive(true);
	}
	// Update is called once per frame
	public void quit () {
		Application.Quit();
	}

	public void changelevel(string scene){
		SceneManager.LoadScene (scene);
}
}
