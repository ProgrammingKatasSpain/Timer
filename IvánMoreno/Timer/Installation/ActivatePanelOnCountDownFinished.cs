using UnityEngine;

public class ActivatePanelOnCountDownFinished : MonoBehaviour
{
    [SerializeField] private CountDownInstaller countdownInstaller = null;
    [SerializeField] private GameObject panel = null;

    private void Start()
    {
        countdownInstaller.AddDelegateOnCounterFinished(ActivatePanel);
    }

    private void ActivatePanel() => panel.SetActive(true);
}