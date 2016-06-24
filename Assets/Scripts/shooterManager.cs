/*PeriodicTable2.0 - Explore the periodic table in VR
	Copyright (C) 2016  Marty Markenson

	This program is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

		You should have received a copy of the GNU General Public License
		along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using UnityEngine;
using System.Collections;

public class shooterManager : MonoBehaviour {
	public float gazeSpeed; //speed object approaches gaze
	private int fireSpeed;
	private float step; //step = speed * Time.deltaTime
	private bool fired, shooter;
	private Vector3 hitPoint; //hitPoint is where the user is looking at
	private elementManager parentElementManager;

	void Start () {
		fired = false; 
		step = gazeSpeed * Time.deltaTime;
		fireSpeed = 10;
		shooter = true;
		parentElementManager = transform.parent.GetComponent<elementManager> ();
	}

	void Update () {
		if (fired == false) {
			transform.position = Vector3.MoveTowards (transform.position, rayCastManager.hitPoint + rayCastManager.direction, step);

			if (GameObject.FindWithTag ("gazeObject") == null) {
				gameObject.GetComponent<Rigidbody> ().AddForce (fireSpeed * rayCastManager.direction, ForceMode.Impulse);
				fired = true;
			}
		}
	}
		
	public void OnCollisionEnter(Collision c) {
		if (shooter) {
			canvasManager.shotsLeft--;
			shooter = false;
		}

		//if it is another diatomic atom that it is not a compound connect the atoms and add a random force
		if (c.rigidbody != null && gameObject.GetComponent<atomManager>().isDiatomic() && c.gameObject.GetComponent<atomManager>().isDiatomic() && !gameObject.GetComponent<atomManager> ().isCompound() && !c.gameObject.GetComponent<atomManager>().isCompound() && gameObject.GetComponent<atomManager>().getAtomicNumber()== c.gameObject.GetComponent<atomManager>().getAtomicNumber()) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			gameObject.GetComponent<atomManager> ().setCompound (true);
			c.gameObject.GetComponent<atomManager> ().setCompound (true);
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);
			//if it was shot it will increase the score
			if (gameObject.tag == "shooter") {
				++canvasManager.compoundsFormed;
				parentElementManager.incrementCompounds ();
			}
		}
	}

	//Getters and Setters


	public void setShooter(bool isShooter) {
		shooter = isShooter;
	}
}
