using UnityEngine;
using NaughtyAttributes; 

public class TargetFrameRateHelper : MonoBehaviour
{
    public int frameRate;
    public bool startWithFrameRate;
    
    void Awake()
    {
        
    }

    void Start()
    {
        if (startWithFrameRate) Application.targetFrameRate = frameRate;
    }

    [Button("Apply Frame Rate")]
    public void ApplyFrameRate()
    {
        Application.targetFrameRate = frameRate;
    }
}
