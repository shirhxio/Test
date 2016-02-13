using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
	// Instantiate a prefab with an attached Missile script
	public Missile projectile;

	void Update () {
		// Ctrl was pressed, launch a projectile
		if (Input.GetButtonDown("Fire1")) {
			// Instantiate the projectile at the position and rotation of this transform
			Missile clone = (Missile)Instantiate(projectile, transform.position, transform.rotation);
			clone.transform.position = clone.transform.position + Vector3.up;
			// Set the missiles timeout destructor to 5
			clone.timeoutDestructor += 5;
		}
	}
}