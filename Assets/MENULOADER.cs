using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENULOADER : MonoBehaviour {


	public void play()
    {

        SceneManager.LoadScene("SampleScene");
		
	}
    public void CREDITS()
    {
        SceneManager.LoadScene("CREDITSMENU");
    }
    public void back()
    {
        SceneManager.LoadScene("MENU");
    }
}
