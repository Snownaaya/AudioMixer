using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixerHandler : MonoBehaviour
{
    [SerializeField] protected AudioMixer _mixer;
    [SerializeField] protected Slider _volumeSlider;
    [SerializeField] protected Button _button;

    protected float _minValueMusic = -80f;
    protected float _maxValueMusic = 20f;
    protected float _lastValueMusic = 0f;

    public void SetVolume(string parameter, float volume)
    {
        float logVolume = Mathf.Log10(volume) * 20;
        logVolume = Mathf.Clamp(logVolume, _minValueMusic, _maxValueMusic);
        _mixer.SetFloat(parameter, logVolume);
    }
}
