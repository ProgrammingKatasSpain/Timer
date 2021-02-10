using UnityEngine;
using UnityEngine.UI;

public class CountDownView : MonoBehaviour
{
    [SerializeField] private CountDownInstaller countdown = null;
    [SerializeField] private Text timeText = null;

    private void Start()
    {
        countdown.AddDelegateOnCounterUpdated(UpdateTimeText);
    }

    private void UpdateTimeText(float _currentTime)
    {
        timeText.text = _currentTime.ToString("0.00");
    }
}