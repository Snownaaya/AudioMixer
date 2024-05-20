using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumePanel : MonoBehaviour
{
    private const string MasterMusic = nameof(MasterMusic);
    protected const string EffectButton = nameof(EffectButton);
    protected const string MusicVolume = nameof(MusicVolume);

    [field: SerializeField] public AudioMixerGroup _audioMixer;
    [field: SerializeField] public Slider _slider;
    [field: SerializeField] public Button _button;

    protected bool _isMuted = false;

    protected float _minValueMusic = -80f;
    protected float _maxValueMusic = 0f;

    private void Start()
    {
        _button.onClick.AddListener(ToggleMute);
        _slider.onValueChanged.AddListener(OnChangeVolume);
    }

    public void OnChangeVolume(float volume) => _audioMixer.audioMixer.SetFloat(MasterMusic, Mathf.Lerp(_minValueMusic, _maxValueMusic, volume));

    private void ToggleMute()
    {
        _isMuted = !_isMuted;

        float targetVolume = _isMuted ? _minValueMusic : _maxValueMusic;

        _audioMixer.audioMixer.SetFloat(MasterMusic, targetVolume);
        _audioMixer.audioMixer.SetFloat(EffectButton, targetVolume);
        _audioMixer.audioMixer.SetFloat(MusicVolume, targetVolume);

        _slider.value = _isMuted ? 0f : 1f;

        OnMuteToggle(_isMuted);
    }

    protected virtual void OnMuteToggle(bool isMuted) { }
}
