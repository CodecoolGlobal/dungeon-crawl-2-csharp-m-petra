﻿using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Assets.Source.Core
{
    /// <summary>
    ///     Class for handling text on user interface (UI)
    /// </summary>
    public class UserInterface : MonoBehaviour
    {
        public enum TextPosition : byte
        {
            TopLeft,
            TopCenter,
            TopRight,
            MiddleLeft,
            MiddleCenter,
            MiddleRight,
            BottomLeft,
            BottomCenter,
            BottomRight
        }

        /// <summary>
        ///     User Interface singleton
        /// </summary>
        public static UserInterface Singleton { get; private set; }

        private TextMeshProUGUI[] _textComponents;

        public void Clear()
        {
            foreach (var component in _textComponents)
            {
                if (component.text != null)
                    component.text = null;
                    
            }
        }

        private void Awake()
        {
            if (Singleton != null)
            {
                Destroy(this);
                return;
            }

            Singleton = this;

            _textComponents = GetComponentsInChildren<TextMeshProUGUI>();
        }

        /// <summary>
        ///     Changes text at given screen position
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textPosition"></param>
        public void SetText(string text, TextPosition textPosition)
        {
            _textComponents[(int)textPosition].text = text;
        }

        public async void DeleteDisplay(int time)
        {
            await Task.Delay(TimeSpan.FromSeconds(time));
            UserInterface.Singleton.SetText("", UserInterface.TextPosition.TopRight);
        }
    }
}
