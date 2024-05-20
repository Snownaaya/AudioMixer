using UnityEngine;
public class BackroundMusic : VolumePanel
{
    private void Start() => _slider.onValueChanged.AddListener(OnVolumeChanged);

    private void OnDisable() => _slider.onValueChanged.RemoveListener(OnVolumeChanged);

    protected override void OnMuteToggle(bool isMuted) => _slider.value = isMuted ? 0f : 1f;

    private void OnVolumeChanged(float volume) => _audioMixer.audioMixer.SetFloat(MusicVolume, Mathf.Lerp(_minValueMusic, _maxValueMusic, volume));
}