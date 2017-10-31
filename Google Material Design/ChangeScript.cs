using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ChangeScript : MonoBehaviour
{
	public void changeToScene(int changeTheScene)
	{
		SceneManager.LoadScene (changeTheScene);
		//	Debug.Log ("called");
	}
}
