﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : Collectable {

	// Use this for initialization
	protected override void OnGhostHit(Ghost ghost){
		LevelController.current.addDonut();
		CollectedHide ();
	}
}
