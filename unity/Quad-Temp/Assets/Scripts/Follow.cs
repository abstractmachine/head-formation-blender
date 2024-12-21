using UnityEngine;

public class Follow : MonoBehaviour
{

	// Follow the target
	public Transform target;
	// Main Camera
	public Camera mainCamera;
	// Set the offset
	public Vector3 offset = new Vector3(0, 0, -10);
	// Set the LERP speed with a RANGE
	[Range(0, 0.5f)]
	public float lerpSpeed = 0.005f;

	void Start()
	{
		mainCamera = Camera.main;
	}

	void Update()
	{
		// Follow the target using LERP and set the offset
		if (target != null)
		{
			Vector3 targetPosition = target.position + offset;
			Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, lerpSpeed);
			transform.position = smoothPosition;
		}
	}
}
