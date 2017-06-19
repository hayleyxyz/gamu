using System;
using System.Collections.Generic;

namespace YuiGameLib.Input {
    public class Mouse {

        protected Dictionary<MouseButton, bool> State;
        protected Dictionary<MouseButton, bool> PressedState;

        public Mouse() {
            this.State = new Dictionary<MouseButton, bool>();
            this.PressedState = new Dictionary<MouseButton, bool>();
        }

        public bool IsButtonDownOnce(MouseButton button) {
            if(this.PressedState.ContainsKey(button) && this.PressedState[button]) {
                this.PressedState[button] = false;
                return true;
            }
            else {
                return false;
            }
        }

        public bool IsButtonDown(MouseButton button) {
            return this.State.ContainsKey(button) && this.State[button];
        }

        public void SetButtonDown(MouseButton button) {
            this.State[button] = true;
            this.PressedState[button] = true;
        }

        public void SetButtonUp(MouseButton button) {
            this.State[button] = false;
            this.PressedState[button] = false;
        }

    }
}
