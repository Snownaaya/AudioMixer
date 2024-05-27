using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _volumeSlider;

    private float _minValueMusic = -80f;
    private float _maxValueMusic = 20f;

    private void Start() => _volumeSlider.onValueChanged.AddListener(SetVolume);

    private void OnDisable() => _volumeSlider.onValueChanged.RemoveListener(SetVolume);

    private void SetVolume(float volume)
    {
        float logVolume = Mathf.Log10(volume) * 20;
        logVolume = Mathf.Clamp(logVolume, _minValueMusic, _maxValueMusic);
        _mixer.SetFloat(MusicVolume, logVolume);
    }
}