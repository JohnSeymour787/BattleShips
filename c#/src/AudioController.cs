﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwinGameSDK;


// The Audio Controller is used to mute and unmute the ingame sounds

public static class AudioController
{
    public static bool _mutedSound = false;

    public static void Mute()
    {

        if (SwinGame.KeyTyped(KeyCode.MKey))
        {
            SwinGame.SetMusicVolume(0);

            _mutedSound = true;
        }

        if (SwinGame.KeyTyped(KeyCode.NKey))
        {
            SwinGame.SetMusicVolume(100);

            _mutedSound = false;
        }
    }
}