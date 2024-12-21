using UnityEngine;
using System.Collections;

public class Stepper : MonoBehaviour
{
	// Left Step Audio File
	public AudioClip leftStep;
	// Right Step Audio File
	public AudioClip rightStep;

	public bool showDebug = false;

	// Listen for Animation Clip Events
	// https://docs.unity3d.com/Manual/script-AnimationWindowEvent.html

	public void Step(string foot)
	{
		if (showDebug) {
			Debug.Log(gameObject.name + "\t" + foot);
		}

		// Play the left step sound and there is a left step sound
		if (foot == "Left" && leftStep != null)
		{
			AudioSource.PlayClipAtPoint(leftStep, transform.position);
		}
		// Play the right step sound and there is a right step sound
		else if (foot == "Right" && rightStep != null)
		{
			AudioSource.PlayClipAtPoint(rightStep, transform.position);
		}
	}
}
