using System;
using UnityEngine;
using CementTools;

// This is an example Mod class
public class ExampleMod : CementMod {

	// The Cement Mod Class inherits from MonoBehaviour, so you can use all the methods of MonoBehaviour.

    public void Start() {
		// Called once
		Cement.Log("Loaded my mod!");
    }
    
    public void Update() {
		// Called once every frame, in every scene
    }
}