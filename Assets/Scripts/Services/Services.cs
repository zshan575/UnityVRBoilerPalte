﻿using IngameDebugConsole;
using UnityEngine;
using Zenject;

public class Services : SingletonMonobehaviour<Services>
{
    public bool clearPrefs;

    #region Variables

    [Inject] private PlayerService _playerService;
    [Inject] private BackLogService _backLogService;
    [Inject] private InputService _inputService;
    [Inject] private UIService _uiService;
    [Inject] private AudioService _audioService;
    [Inject] private CameraService _cameraService;
    [Inject] private GameService _gameService;
    [Inject] private ScoreService _scoreService;
    [Inject] private VibrationService _vibrationService;
    [Inject] private EffectService _effectService;
    [Inject] private SceneService _sceneService;
    [Inject] private GameElements _gameElements;
    [Inject] private Canvas _canvas;
    [Inject] private DebugLogManager _debugConsole;
    [Inject] ServicesOrganizer _servicesOrganizer;
    [Inject] SignalBus _signalBus;

    #endregion

    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    public void CameraUpdateAssign()
    {
        Canvas.renderMode = RenderMode.WorldSpace;
        Canvas.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-10f, 0f,20f);
        Canvas.worldCamera = Camera.main;
    }
    private void Update()
    {
        if (clearPrefs)
        {
            clearPrefs = false;
            PlayerPrefs.DeleteAll();
            PlayerService.ResetPlayer();
            Debug.Log("Prefs Cleared");
        }
    }

    #region public api

    public static Canvas Canvas
    {
        get { return instance._canvas; }
    }

    public static PlayerService PlayerService
    {
        get { return instance._playerService; }
    }

    public static BackLogService BackLogService
    {
        get { return instance._backLogService; }
    }

    public static InputService InputService
    {
        get { return instance._inputService; }
    }

    public static GameObject DebugConsole
    {
        get { return instance._debugConsole.gameObject; }
    }

    public static GameElements GameElements
    {
        get { return instance._gameElements; }
    }

    public static UIService UIService
    {
        get { return instance._uiService; }
    }

    public static AudioService AudioService
    {
        get { return instance._audioService; }
    }

    public static CameraService CameraService
    {
        get { return instance._cameraService; }
    }

    public static GameService GameService
    {
        get { return instance._gameService; }
    }

    public static ScoreService ScoreService
    {
        get { return instance._scoreService; }
    }

    public static EffectService EffectService
    {
        get { return instance._effectService; }
    }

    public static SceneService SceneService
    {
        get { return instance._sceneService; }
    }

    public static VibrationService vibrationService
    {
        get { return instance._vibrationService; }
    }

    public static ServicesOrganizer ServicesOrganizer
    {
        get { return instance._servicesOrganizer; }
    }

    public static SignalBus SignalBus
    {
        get { return instance._signalBus; }
    }

    #endregion
}