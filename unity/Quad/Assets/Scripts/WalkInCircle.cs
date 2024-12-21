using UnityEngine;
using System.Collections.Generic;

public class WalkInCircle : MonoBehaviour
{
// collection of all the Animators in the children
	Animator[] animators;

	// named array using a dictionary
    Dictionary<string, float> times = new Dictionary<string, float>
    {
        { "A", 0.0f },
        { "B", 0.0f },
        { "C", 0.0f },
		{ "D", 0.0f }
    };

	void Start()
	{
		// get all the animators in the children
		animators = GetComponentsInChildren<Animator>();

		// hide cursor
		Cursor.visible = false;
	}


	void Update() {

		string input = Input.inputString.ToUpper();

		// did the user press the A, B, C, or D key?
		if (input == "A" || input == "B" || input == "C" || input == "D") {
			
			// convert letter to upper case
			string letter = Input.inputString.ToUpper();

			// go through each animator
			foreach (Animator animator in animators) {
				// make sure it has the same name
				if (animator.gameObject.name == letter) {
					// get the current state of the boolean parameter
					bool state = animator.GetBool("Started");
					// if we are playing, get the current time of the animation
					float normalizedTime = animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
					// rember the time for the next time we play
					times[letter] = normalizedTime;
					// invert state
					state = !state;
					// if we are playing
					if (state) {
						// set the current animation time to the last time we played

					}
					// change the boolean parameter
					animator.SetBool("Started", state);
				}
			}

		}

	}
}
