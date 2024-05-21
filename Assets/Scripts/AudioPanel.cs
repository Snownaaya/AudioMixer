using UnityEngine;
using UnityEngine.Audio;

public class AudioPanel : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private float _minValueMusic = -80f;
    private float _maxValueMusic = 0f;

    public void SetVolume(string parameter, float volume) => _mixer.SetFloat(parameter, Mathf.Lerp(_minValueMusic, _maxValueMusic, volume));
}
