using System;
using UnityEngine;
using IMoreno.Timer;

public class CountDownInstaller : MonoBehaviour
{
    [SerializeField] private float time = 5;

    private Action OnCountdownEnded;
    private Action<float> OnCountdownUpdated;

    private Countdown countdown;

    private void Awake()
    {
        ITimer<float> timer = new Timer();

        countdown = new Countdown(timer, time);

        countdown.OnCountDownFinished += OnCounterFinishedCallback;
        countdown.OnCountDownUpdated += OnCounterUpdatedCallback;
    }

    private void Update()
    {
        countdown.Add(Time.deltaTime);
    }

    private void OnCounterFinishedCallback() => OnCountdownEnded?.Invoke();
    private void OnCounterUpdatedCallback(float _currentTime)
    {
        OnCountdownUpdated?.Invoke(_currentTime);
    }

    public void AddDelegateOnCounterFinished(Action _delegate) => OnCountdownEnded += _delegate;
    public void RemoveDelegateOnCounterFinished(Action _delegate) => OnCountdownEnded -= _delegate;

    public void AddDelegateOnCounterUpdated(Action<float> _delegate) => OnCountdownUpdated += _delegate;
    public void RemoveDelegateOnCounterUpdated(Action<float> _delegate) => OnCountdownUpdated -= _delegate;
}