using UnityEngine;

public class Rotator : MonoBehaviour {

	[SerializeField] private float f_RotationSpeed = 100f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 0f, f_RotationSpeed * Time.deltaTime);
	}
}
