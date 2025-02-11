﻿using BitsCore.Rendering.Display;
using GLFW;
using System.Numerics;

namespace BitsCore.InputSystem
{
    /// <summary> Gather info about the various input-methods. </summary>
    public static class Input
    {
        /// <summary> The Distance the mouse travelled during the last frame. </summary>
        public static Vector2 mouseDelta { get; internal set; }
        /// <summary> The Distance the mouse-scroll travelled during the last frame. </summary>
        public static float scrollDelta { get; internal set; }

        /// <summary> 
        /// Check whether a Key is currently being of the given state. 
        /// </summary>
        /// <param name="key"> The key to be checked. </param>
        /// <param name="state"> The state to be checked for. </param>
        public static bool IsState(KeyCode key, InputState state)
        {
            //mapping glfw keys to our keycodes
            if (key == KeyCode.Unknown) { return false; }
            else if (key == KeyCode.Space) { return Glfw.GetKey(DisplayManager.Window, Keys.Space) == (GLFW.InputState)state; }
            else if (key == KeyCode.Apostrophe) { return Glfw.GetKey(DisplayManager.Window, Keys.Apostrophe) == (GLFW.InputState)state; }
            else if (key == KeyCode.Comma) { return Glfw.GetKey(DisplayManager.Window, Keys.Comma) == (GLFW.InputState)state; }
            else if (key == KeyCode.Minus) { return Glfw.GetKey(DisplayManager.Window, Keys.Minus) == (GLFW.InputState)state; }
            else if (key == KeyCode.Period) { return Glfw.GetKey(DisplayManager.Window, Keys.Period) == (GLFW.InputState)state; }
            else if (key == KeyCode.Slash) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha0) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha1) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha2) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha3) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha4) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha5) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha6) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha7) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha8) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Alpha9) { return Glfw.GetKey(DisplayManager.Window, Keys.Slash) == (GLFW.InputState)state; }
            else if (key == KeyCode.SemiColon) { return Glfw.GetKey(DisplayManager.Window, Keys.SemiColon) == (GLFW.InputState)state; }
            else if (key == KeyCode.Equal) { return Glfw.GetKey(DisplayManager.Window, Keys.Equal) == (GLFW.InputState)state; }
            else if (key == KeyCode.A) { return Glfw.GetKey(DisplayManager.Window, Keys.A) == (GLFW.InputState)state; }
            else if (key == KeyCode.B) { return Glfw.GetKey(DisplayManager.Window, Keys.B) == (GLFW.InputState)state; }
            else if (key == KeyCode.C) { return Glfw.GetKey(DisplayManager.Window, Keys.C) == (GLFW.InputState)state; }
            else if (key == KeyCode.D) { return Glfw.GetKey(DisplayManager.Window, Keys.D) == (GLFW.InputState)state; }
            else if (key == KeyCode.E) { return Glfw.GetKey(DisplayManager.Window, Keys.E) == (GLFW.InputState)state; }
            else if (key == KeyCode.F) { return Glfw.GetKey(DisplayManager.Window, Keys.F) == (GLFW.InputState)state; }
            else if (key == KeyCode.G) { return Glfw.GetKey(DisplayManager.Window, Keys.G) == (GLFW.InputState)state; }
            else if (key == KeyCode.H) { return Glfw.GetKey(DisplayManager.Window, Keys.H) == (GLFW.InputState)state; }
            else if (key == KeyCode.I) { return Glfw.GetKey(DisplayManager.Window, Keys.I) == (GLFW.InputState)state; }
            else if (key == KeyCode.J) { return Glfw.GetKey(DisplayManager.Window, Keys.J) == (GLFW.InputState)state; }
            else if (key == KeyCode.K) { return Glfw.GetKey(DisplayManager.Window, Keys.K) == (GLFW.InputState)state; }
            else if (key == KeyCode.L) { return Glfw.GetKey(DisplayManager.Window, Keys.L) == (GLFW.InputState)state; }
            else if (key == KeyCode.M) { return Glfw.GetKey(DisplayManager.Window, Keys.M) == (GLFW.InputState)state; }
            else if (key == KeyCode.N) { return Glfw.GetKey(DisplayManager.Window, Keys.N) == (GLFW.InputState)state; }
            else if (key == KeyCode.O) { return Glfw.GetKey(DisplayManager.Window, Keys.O) == (GLFW.InputState)state; }
            else if (key == KeyCode.P) { return Glfw.GetKey(DisplayManager.Window, Keys.P) == (GLFW.InputState)state; }
            else if (key == KeyCode.Q) { return Glfw.GetKey(DisplayManager.Window, Keys.Q) == (GLFW.InputState)state; }
            else if (key == KeyCode.R) { return Glfw.GetKey(DisplayManager.Window, Keys.R) == (GLFW.InputState)state; }
            else if (key == KeyCode.S) { return Glfw.GetKey(DisplayManager.Window, Keys.S) == (GLFW.InputState)state; }
            else if (key == KeyCode.T) { return Glfw.GetKey(DisplayManager.Window, Keys.T) == (GLFW.InputState)state; }
            else if (key == KeyCode.U) { return Glfw.GetKey(DisplayManager.Window, Keys.U) == (GLFW.InputState)state; }
            else if (key == KeyCode.V) { return Glfw.GetKey(DisplayManager.Window, Keys.V) == (GLFW.InputState)state; }
            else if (key == KeyCode.W) { return Glfw.GetKey(DisplayManager.Window, Keys.W) == (GLFW.InputState)state; }
            else if (key == KeyCode.X) { return Glfw.GetKey(DisplayManager.Window, Keys.X) == (GLFW.InputState)state; }
            else if (key == KeyCode.Y) { return Glfw.GetKey(DisplayManager.Window, Keys.Y) == (GLFW.InputState)state; }
            else if (key == KeyCode.Z) { return Glfw.GetKey(DisplayManager.Window, Keys.Z) == (GLFW.InputState)state; }
            else if (key == KeyCode.LeftBracket) { return Glfw.GetKey(DisplayManager.Window, Keys.LeftBracket) == (GLFW.InputState)state; }
            else if (key == KeyCode.Backslash) { return Glfw.GetKey(DisplayManager.Window, Keys.Backslash) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightBracket) { return Glfw.GetKey(DisplayManager.Window, Keys.RightBracket) == (GLFW.InputState)state; }
            else if (key == KeyCode.GraveAccent) { return Glfw.GetKey(DisplayManager.Window, Keys.GraveAccent) == (GLFW.InputState)state; }
            else if (key == KeyCode.World1) { return Glfw.GetKey(DisplayManager.Window, Keys.World1) == (GLFW.InputState)state; }
            else if (key == KeyCode.World2) { return Glfw.GetKey(DisplayManager.Window, Keys.World2) == (GLFW.InputState)state; }
            else if (key == KeyCode.Escape) { return Glfw.GetKey(DisplayManager.Window, Keys.Escape) == (GLFW.InputState)state; }
            else if (key == KeyCode.Enter) { return Glfw.GetKey(DisplayManager.Window, Keys.Enter) == (GLFW.InputState)state; }
            else if (key == KeyCode.Tab) { return Glfw.GetKey(DisplayManager.Window, Keys.Tab) == (GLFW.InputState)state; }
            else if (key == KeyCode.Backspace) { return Glfw.GetKey(DisplayManager.Window, Keys.Backslash) == (GLFW.InputState)state; }
            else if (key == KeyCode.Insert) { return Glfw.GetKey(DisplayManager.Window, Keys.Insert) == (GLFW.InputState)state; }
            else if (key == KeyCode.Delete) { return Glfw.GetKey(DisplayManager.Window, Keys.Delete) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightArrow) { return Glfw.GetKey(DisplayManager.Window, Keys.Right) == (GLFW.InputState)state; }
            else if (key == KeyCode.LeftArrow) { return Glfw.GetKey(DisplayManager.Window, Keys.Left) == (GLFW.InputState)state; }
            else if (key == KeyCode.DownArrow) { return Glfw.GetKey(DisplayManager.Window, Keys.Down) == (GLFW.InputState)state; }
            else if (key == KeyCode.UpArrow) { return Glfw.GetKey(DisplayManager.Window, Keys.Up) == (GLFW.InputState)state; }
            else if (key == KeyCode.PageUp) { return Glfw.GetKey(DisplayManager.Window, Keys.PageUp) == (GLFW.InputState)state; }
            else if (key == KeyCode.PageDown) { return Glfw.GetKey(DisplayManager.Window, Keys.PageDown) == (GLFW.InputState)state; }
            else if (key == KeyCode.Home) { return Glfw.GetKey(DisplayManager.Window, Keys.Home) == (GLFW.InputState)state; }
            else if (key == KeyCode.End) { return Glfw.GetKey(DisplayManager.Window, Keys.End) == (GLFW.InputState)state; }
            else if (key == KeyCode.CapsLock) { return Glfw.GetKey(DisplayManager.Window, Keys.CapsLock) == (GLFW.InputState)state; }
            else if (key == KeyCode.ScrollLock) { return Glfw.GetKey(DisplayManager.Window, Keys.ScrollLock) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumLock) { return Glfw.GetKey(DisplayManager.Window, Keys.NumLock) == (GLFW.InputState)state; }
            else if (key == KeyCode.PrintScreen) { return Glfw.GetKey(DisplayManager.Window, Keys.PrintScreen) == (GLFW.InputState)state; }
            else if (key == KeyCode.Pause) { return Glfw.GetKey(DisplayManager.Window, Keys.Pause) == (GLFW.InputState)state; }
            else if (key == KeyCode.F1) { return Glfw.GetKey(DisplayManager.Window, Keys.F1) == (GLFW.InputState)state; }
            else if (key == KeyCode.F2) { return Glfw.GetKey(DisplayManager.Window, Keys.F2) == (GLFW.InputState)state; }
            else if (key == KeyCode.F3) { return Glfw.GetKey(DisplayManager.Window, Keys.F3) == (GLFW.InputState)state; }
            else if (key == KeyCode.F4) { return Glfw.GetKey(DisplayManager.Window, Keys.F4) == (GLFW.InputState)state; }
            else if (key == KeyCode.F5) { return Glfw.GetKey(DisplayManager.Window, Keys.F5) == (GLFW.InputState)state; }
            else if (key == KeyCode.F6) { return Glfw.GetKey(DisplayManager.Window, Keys.F6) == (GLFW.InputState)state; }
            else if (key == KeyCode.F7) { return Glfw.GetKey(DisplayManager.Window, Keys.F7) == (GLFW.InputState)state; }
            else if (key == KeyCode.F8) { return Glfw.GetKey(DisplayManager.Window, Keys.F8) == (GLFW.InputState)state; }
            else if (key == KeyCode.F9) { return Glfw.GetKey(DisplayManager.Window, Keys.F9) == (GLFW.InputState)state; }
            else if (key == KeyCode.F10) { return Glfw.GetKey(DisplayManager.Window, Keys.F10) == (GLFW.InputState)state; }
            else if (key == KeyCode.F11) { return Glfw.GetKey(DisplayManager.Window, Keys.F11) == (GLFW.InputState)state; }
            else if (key == KeyCode.F12) { return Glfw.GetKey(DisplayManager.Window, Keys.F12) == (GLFW.InputState)state; }
            else if (key == KeyCode.F13) { return Glfw.GetKey(DisplayManager.Window, Keys.F13) == (GLFW.InputState)state; }
            else if (key == KeyCode.F14) { return Glfw.GetKey(DisplayManager.Window, Keys.F14) == (GLFW.InputState)state; }
            else if (key == KeyCode.F15) { return Glfw.GetKey(DisplayManager.Window, Keys.F15) == (GLFW.InputState)state; }
            else if (key == KeyCode.F16) { return Glfw.GetKey(DisplayManager.Window, Keys.F16) == (GLFW.InputState)state; }
            else if (key == KeyCode.F17) { return Glfw.GetKey(DisplayManager.Window, Keys.F17) == (GLFW.InputState)state; }
            else if (key == KeyCode.F18) { return Glfw.GetKey(DisplayManager.Window, Keys.F18) == (GLFW.InputState)state; }
            else if (key == KeyCode.F19) { return Glfw.GetKey(DisplayManager.Window, Keys.F19) == (GLFW.InputState)state; }
            else if (key == KeyCode.F20) { return Glfw.GetKey(DisplayManager.Window, Keys.F20) == (GLFW.InputState)state; }
            else if (key == KeyCode.F21) { return Glfw.GetKey(DisplayManager.Window, Keys.F21) == (GLFW.InputState)state; }
            else if (key == KeyCode.F22) { return Glfw.GetKey(DisplayManager.Window, Keys.F22) == (GLFW.InputState)state; }
            else if (key == KeyCode.F23) { return Glfw.GetKey(DisplayManager.Window, Keys.F23) == (GLFW.InputState)state; }
            else if (key == KeyCode.F24) { return Glfw.GetKey(DisplayManager.Window, Keys.F24) == (GLFW.InputState)state; }
            else if (key == KeyCode.F25) { return Glfw.GetKey(DisplayManager.Window, Keys.F25) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad0) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad0) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad1) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad1) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad2) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad2) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad3) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad3) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad4) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad4) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad5) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad5) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad6) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad6) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad7) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad7) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad8) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad8) == (GLFW.InputState)state; }
            else if (key == KeyCode.Numpad9) { return Glfw.GetKey(DisplayManager.Window, Keys.Numpad9) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadDecimal) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadDecimal) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadDivide) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadDivide) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadMultiply) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadMultiply) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadSubtract) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadSubtract) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadAdd) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadAdd) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadEnter) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadEnter) == (GLFW.InputState)state; }
            else if (key == KeyCode.NumpadEqual) { return Glfw.GetKey(DisplayManager.Window, Keys.NumpadEqual) == (GLFW.InputState)state; }
            else if (key == KeyCode.LeftShift) { return Glfw.GetKey(DisplayManager.Window, Keys.LeftShift) == (GLFW.InputState)state; }
            else if (key == KeyCode.LeftControl) { return Glfw.GetKey(DisplayManager.Window, Keys.LeftControl) == (GLFW.InputState)state; }
            else if (key == KeyCode.LeftAlt) { return Glfw.GetKey(DisplayManager.Window, Keys.LeftAlt) == (GLFW.InputState)state; }
            else if (key == KeyCode.LeftSuper) { return Glfw.GetKey(DisplayManager.Window, Keys.LeftSuper) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightShift) { return Glfw.GetKey(DisplayManager.Window, Keys.RightShift) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightControl) { return Glfw.GetKey(DisplayManager.Window, Keys.RightControl) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightAlt) { return Glfw.GetKey(DisplayManager.Window, Keys.RightAlt) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightSuper) { return Glfw.GetKey(DisplayManager.Window, Keys.RightSuper) == (GLFW.InputState)state; }
            else if (key == KeyCode.Menu) { return Glfw.GetKey(DisplayManager.Window, Keys.Menu) == (GLFW.InputState)state; }

            //additional keycodes
            else if (key == KeyCode.LeftWinMacSymbol) { return Glfw.GetKey(DisplayManager.Window, Keys.LeftSuper) == (GLFW.InputState)state; }
            else if (key == KeyCode.RightWinMacSymbol) { return Glfw.GetKey(DisplayManager.Window, Keys.RightSuper) == (GLFW.InputState)state; }

            return false;
        }
        /// <summary> 
        /// Check whether a Key is currently being pressed. 
        /// <para> Returns true every frame while the key is pressed. </para>
        /// </summary>
        /// <param name="key"> The key to be checked. </param>
        public static bool IsDown(KeyCode key)
        {
            return IsState(key, InputState.Press);
        }
        /// <summary> 
        /// Check whether two Keys are currently being pressed. 
        /// <para> Returns true every frame while the keys are pressed. </para>
        /// </summary>
        /// <param name="key1"> The first key to be checked. </param>
        /// <param name="key2"> The second key to be checked. </param>
        public static bool IsDown(KeyCode key1, KeyCode key2)
        {
            return IsState(key1, InputState.Press) && IsState(key2, InputState.Press);
        }
        /// <summary> Check whether a Key is currently released (not being pressed). </summary>
        /// <param name="key"> The key to be checked. </param>
        public static bool IsReleased(KeyCode key)
        {
            return IsState(key, InputState.Release);
        }
        /// <summary> 
        /// Check whether two Keys are currently released(not pressed). 
        /// <para> Returns true every frame while the keys aren't pressed. </para>
        /// </summary>
        /// <param name="key1"> The first key to be checked. </param>
        /// <param name="key2"> The second key to be checked. </param>
        public static bool IsReleased(KeyCode key1, KeyCode key2)
        {
            return IsState(key1, InputState.Release) && IsState(key2, InputState.Release);
        }

        /// <summary> 
        /// Check whether a key is pressed and not held.
        /// <para> Returns true the first frame the Key is held/pressed and resets when the Mouse-Button is released. </para>
        /// </summary>
        /// <param name="mouseButton"> The Mouse-Button to be checked. </param>

        public static bool IsPressed(KeyCode key)
        {
            return IsDown(key) && InputManager.GetKeyState(key);
        }

        /// <summary> Check whether a Mouse-Button is currently being pressed. </summary>
        /// <param name="mouseButton"> The Mouse-Button to be checked. </param>
        public static bool IsMouseDown(MouseButton mouseButton)
        {
            //can cast because our mouse-buttons are copied from glfw
            if (mouseButton == MouseButton.Button1) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button2) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button3) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button4) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button5) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button6) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button7) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Button8) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Left) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Right) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }
            else if (mouseButton == MouseButton.Middle) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Press; }

            return false;
        }

        /// <summary> Check whether a Mouse-Button is currently released(not being pressed). </summary>
        /// <param name="mouseButton"> The Mouse-Button to be checked. </param>
        public static bool IsMouseReleased(MouseButton mouseButton)
        {
            //can cast because our mouse-buttons are copied from glfw
            if (mouseButton == MouseButton.Button1) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button2) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button3) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button4) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button5) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button6) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button7) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Button8) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Left) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Right) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }
            else if (mouseButton == MouseButton.Middle) { return Glfw.GetMouseButton(DisplayManager.Window, (GLFW.MouseButton)mouseButton) == GLFW.InputState.Release; }

            return false;
        }

        /// <summary> 
        /// Check whether a Mouse-Button is pressed and not held. 
        /// <para> Returns true the first frame the Mouse-Button is held/pressed and resets when the Mouse-Button is released. </para>
        /// </summary>
        /// <param name="mouseButton"> The Mouse-Button to be checked. </param>
        public static bool IsMousePressed(MouseButton mouseButton)
        {
            return IsMouseDown(mouseButton) && InputManager.GetMouseButtonState(mouseButton);
        }

    }
}
