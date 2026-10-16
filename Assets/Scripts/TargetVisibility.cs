using UnityEngine;
using Vuforia;

public class TargetVisibility : MonoBehaviour
{
    public GameObject arPanel;

    private ObserverBehaviour mObserverBehaviour;

    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
        if (arPanel != null)
            arPanel.SetActive(false);
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED ||
            targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            arPanel.SetActive(true);
        }
        else
        {
            arPanel.SetActive(false);
        }
    }

    void OnDestroy()
    {
        if (mObserverBehaviour)
            mObserverBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
    }
}