/*
  	PeriodicTable2.0 - Explore the periodic table in VR
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
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public static bool playing; //flag for if user is in a round
	public static float timeLeft; //timeLeft before the round is over
	public static int compoundsFormed, levelCount, shotsLeft; //users score and number of levels in the game
	public int compoundGoal, initialShots;
	Animator anim; //controls when instructions, time, score and playagain/next level

	void Start () {
		playing = false;
		shotsLeft = initialShots;
		timeLeft = 60f;
		compoundsFormed = 0;
		levelCount = 3;//this will change with SaveLoad
		anim = GetComponent<Animator> ();
	}

	void Update () {

		if (playing) {
			anim.SetTrigger ("playing"); //score and timeLeft are shown to user
		}

		if (compoundsFormed >= compoundGoal) {
			anim.SetTrigger ("gameOver"); //nextSteps button is shown
			playing = false;
		}

		if (shotsLeft<=0) {
			anim.SetTrigger ("lose"); //nextSteps button is Shown
			playing = false;
		}
	}
		
	public void home() {
		SceneManager.LoadScene (0);
	}

	public int getCompoundGoal() {
		return compoundGoal;
	}
}
