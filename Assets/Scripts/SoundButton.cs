using UnityEngine;

public class SoundButton : VolumePanel
{
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        _button.onClick.AddListener(PlaySound);
        _slider.onValueChanged.AddListener(ToggleMusic);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlaySound);
        _slider.onValueChanged.RemoveListener(ToggleMusic);
    }

    protected override void OnMuteToggle(bool isMuted) => _slider.value = isMuted ? 0f : 1f;

    private void ToggleMusic(float volume) => _audioMixer.audioMixer.SetFloat(EffectButton, Mathf.Lerp(_minValueMusic, _maxValueMusic, volume));

    private void PlaySound() => _audioSource.Play();
}
