using UnityEngine;
using System.Collections;

public class Offset : MonoBehaviour
{
	// collection of all the Animators in the children
	Animator[] animators;

	void Start()
	{
		// get all the animators in the children
		animators = GetComponentsInChildren<Animator>();

		// wait 1 second between starting each animator
		StartCoroutine(StartAnimators());

	}

	IEnumerator StartAnimators() {

		// wait 1 second between starting each animator
		float waitTime = 1.0f;
		// go through each animator
		foreach (Animator animator in animators) {
			yield return new WaitForSeconds(waitTime);
			// change a boolean parameter to start the animator
			animator.SetBool("Started", true);
		}
	}

}
