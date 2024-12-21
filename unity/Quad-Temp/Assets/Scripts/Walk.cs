using System;
using UnityEngine;

public class Walk : MonoBehaviour
{
	bool isWalking = false;

	void Update()
	{
		if (Input.GetKey(KeyCode.Space) && !isWalking)
		{
			isWalking = true;
			// Set state in Animator component
			GetComponent<Animator>().SetBool("Walking", true);

		}
		else if (!Input.GetKey(KeyCode.Space) && isWalking)
		{
			isWalking = false;
			// Set state in Animator component
			GetComponent<Animator>().SetBool("Walking", false);
		}
	}
}
