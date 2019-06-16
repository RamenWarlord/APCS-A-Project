using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour {

	// Use this for initialization
	public void AboutMenu () {
        SceneManager.LoadScene("About", LoadSceneMode.Single);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
