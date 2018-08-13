using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public int noiseWidth;
    public int noiseHeight;
    public float noiseScale;
    public bool autoUpdate;

    // Use this for initialization
    public void GenerateMap()
    {
        float[,] noiseMap = Noise.GenerateNoiseMap(noiseWidth, noiseHeight, noiseScale);
        noiseMap.

        MapDisplay display = FindObjectOfType<MapDisplay>();
        display.drawNoiseMap(noiseMap);
    }

}
