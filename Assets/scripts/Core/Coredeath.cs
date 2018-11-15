using UnityEngine;
using UnityEngine.SceneManagement;

public class Coredeath : MonoBehaviour {



	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "enemy")
		{

			SceneManager.LoadScene("gameover");

		}
	}
}
