using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring
{
    //Settings class
    static class Settings
    {
        public enum InputType
        {
            Keyboard, Pad, Mouse
        };

        public static InputType inputType = InputType.Keyboard;
    }
}
