using UnityEngine;
using UnityEngine.UI;

public class BackroundMusic : MonoBehaviour
{
    protected const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private AudioPanel _audioPanel;
    [SerializeField] private Slider _slider;

    private void Start() => _slider.onValueChanged.AddListener(OnVolumeChanged);

    private void OnDisable() => _slider.onValueChanged.RemoveListener(OnVolumeChanged);

    public void OnVolumeChanged(float volume) => _audioPanel.SetVolume(MusicVolume, volume);
}