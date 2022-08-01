using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    [SerializeField] private Button muteUnmute;
    [SerializeField] private Sprite muteSprite;
    [SerializeField] private Sprite unmuteSprite;

    [SerializeField] private AudioSource bgMusic;

    [SerializeField] private Button muteUnmuteSFX;
    [SerializeField] private Sprite muteSFXSprite;
    [SerializeField] private Sprite unmuteSFXSprite;

    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource bookSound;
    [SerializeField] private AudioSource dirtiedSound;
    [SerializeField] private AudioSource congratsSound;
    [SerializeField] private AudioSource winSound;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        if (!PlayerPrefs.HasKey("isMusicMuted"))
        {
            PlayerPrefs.SetString("isMusicMuted", "unmuted");
            LoadMusicPref();
        }
        else
        {
            LoadMusicPref();
        }
        //SFX Pref Loader
        if (!PlayerPrefs.HasKey("isSFXMuted"))
        {
            PlayerPrefs.SetString("isSFXMuted", "unmuted");
            LoadSFXPref();
        }
        else
        {
            LoadSFXPref();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);

        if (muteUnmute.image.sprite == muteSprite)
        {
            PlayerPrefs.SetString("isMusicMuted", "muted");
        }
        else
        {
            PlayerPrefs.SetString("isMusicMuted", "unmuted");
        }

        //

        if (muteUnmuteSFX.image.sprite == muteSprite)
        {
            PlayerPrefs.SetString("isSFXMuted", "muted");
        }
        else
        {
            PlayerPrefs.SetString("isSFXMuted", "unmuted");
        }
    }

    //////

    public void MuteUnmute()
    {
        if (muteUnmute.image.sprite == unmuteSprite)
        {
            bgMusic.mute = true;
            muteUnmute.image.sprite = muteSprite;
        }
        else
        {
            bgMusic.mute = false;
            muteUnmute.image.sprite = unmuteSprite;
        }
        Save();
    }

    public void MuteUnmuteSFX()
    {
        if (muteUnmuteSFX.image.sprite == unmuteSFXSprite)
        {
            jumpSound.mute = true;
            bookSound.mute = true;
            dirtiedSound.mute = true;
            congratsSound.mute = true;
            winSound.mute = true;

            muteUnmuteSFX.image.sprite = muteSFXSprite;
        }
        else
        {
            jumpSound.mute = false;
            bookSound.mute = false;
            dirtiedSound.mute = false;
            congratsSound.mute = false;
            winSound.mute = false;

            muteUnmuteSFX.image.sprite = unmuteSFXSprite;
        }
        Save();
    }

    private void LoadMusicPref()
    {
        if (PlayerPrefs.GetString("isMusicMuted") == "muted")
        {
            bgMusic.mute = true;
            muteUnmute.image.sprite = muteSprite;
        }
        else
        {
            bgMusic.mute = false;
            muteUnmute.image.sprite = unmuteSprite;
        }
    }

    private void LoadSFXPref()
    {
        if (PlayerPrefs.GetString("isSFXMuted") == "muted")
        {
            jumpSound.mute = true;
            bookSound.mute = true;
            dirtiedSound.mute = true;
            congratsSound.mute = true;
            winSound.mute = true;

            muteUnmuteSFX.image.sprite = muteSFXSprite;
        }
        else
        {
            jumpSound.mute = false;
            bookSound.mute = false;
            dirtiedSound.mute = false;
            congratsSound.mute = false;
            winSound.mute = false;

            muteUnmuteSFX.image.sprite = unmuteSFXSprite;
        }
    }
}
