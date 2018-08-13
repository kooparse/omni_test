using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise {

	public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale = 0.0001f) {
		float [,] noiseMap = new float[mapWidth, mapHeight];

        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
				float sampleX = x / scale;
				float sampleY = y / scale;
				float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);

				noiseMap[x, y] = perlinValue;
            }
        }

		return noiseMap;
	}
}
