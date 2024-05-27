using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    private const string MasterMusic = nameof(MasterMusic);

    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private Button _button;

    private float _minValueMusic = -80f;
    private float _maxValueMusic = 20f;
    private float _lastValueMusic = 0f;

    private bool _isMuted = false;

    public void ToggleMute()
    {
        _isMuted = !_isMuted;

        if (_isMuted)
        {
            _mixer.SetFloat(MasterMusic, _minValueMusic);
            _volumeSlider.interactable = false;
        }
        else
        {
            _mixer.SetFloat(MasterMusic, _lastValueMusic);
            _volumeSlider.interactable = true;
        }
    }

    public void SetVolume(float volume)
    {
        float logVolume = Mathf.Log10(volume) * 20;
        logVolume = Mathf.Clamp(logVolume, _minValueMusic, _maxValueMusic);
        _mixer.SetFloat(MasterMusic, logVolume);
    }
}
