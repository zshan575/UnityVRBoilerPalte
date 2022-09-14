using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using IngameDebugConsole;

[CreateAssetMenu(fileName = "MainSceneElements", menuName = "ScriptableObjects/MainSceneElements", order = 2)]
public class MainSceneElements : ScriptableObject
{
    [Header("Canvas")]
    public Canvas mainSceneCanvasPrefab;
}