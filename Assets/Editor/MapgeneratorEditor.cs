﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]
public class MapgeneratorEditor : Editor {

	public override void OnInspectorGUI() {
		MapGenerator mapGen = (MapGenerator) target;

		if (DrawDefaultInspector() && mapGen.autoUpdate) {
            mapGen.GenerateMap();
		}

		if (GUILayout.Button("Generate")) {
			mapGen.GenerateMap();
		}

	}

}
