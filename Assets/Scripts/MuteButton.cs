using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    private const string MasterMusic = nameof(MasterMusic);

    [SerializeField] private Button _muteButton;
    [SerializeField] private AudioPanel _audioPanel;
    [SerializeField] private Slider _volumeSlider;

    private bool _isMuted = false;

    private void Start()
    {
        _muteButton.onClick.AddListener(ToggleMute);
        _volumeSlider.onValueChanged.AddListener(SetMusicVolume);
    }

    private void OnDisable()
    {
        _muteButton.onClick.RemoveListener(ToggleMute);
        _volumeSlider.onValueChanged.RemoveListener(SetMusicVolume);
    }

    private void ToggleMute()
    {
        _isMuted = !_isMuted;

        if (_isMuted)
            _audioPanel.SetVolume(MasterMusic, 0);
        else
            SetMusicVolume(_volumeSlider.value);
    }

    private void SetMusicVolume(float volume)
    {
        if (_isMuted == false)
            _audioPanel.SetVolume(MasterMusic, volume);
    }
}
