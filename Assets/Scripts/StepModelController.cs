using UnityEngine;

public class StepModelController : MonoBehaviour
{
    public GameObject[] stepModels;
    public float rotationSpeed = 50f;
    public bool rotateLastStep = true;

    private int currentStep = 0;

    private void Start()
    {
        ShowStepModel(0);
    }

    void Update()
    {
        if (rotateLastStep &&
            currentStep == stepModels.Length - 1 &&
            stepModels[currentStep] != null)
        {
            stepModels[currentStep].transform.Rotate(
                Vector3.up,
                rotationSpeed * Time.deltaTime
            );
        }
    }

    public void ShowStepModel(int stepIndex)
    {
        currentStep = stepIndex;

        for (int i = 0; i < stepModels.Length; i++)
        {
            if (stepModels[i] != null)
            {
                stepModels[i].SetActive(i == stepIndex);
            }
        }
    }
}