﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay: MonoBehaviour {

	public Renderer textureRenderer;

	public void drawNoiseMap(float[,] noiseMap) {
		int width = noiseMap.GetLength(0);
		int height = noiseMap.GetLength(1);

		Texture2D texture = new Texture2D(width, height);

		Color[] colorArray = new Color[width * height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < width; y++)
            {
                colorArray[y * width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x, y]);
            }
        }

		texture.SetPixels(colorArray);
		texture.Apply();

		textureRenderer.sharedMaterial.mainTexture = texture;
		textureRenderer.transform.localScale = new Vector3(width, 1, height);
    }

}
