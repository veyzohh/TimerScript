# ⏱️ UdonSharp Timer Script
A simple countdown timer for VRChat using UdonSharp and Unity UI. Displays time remaining and triggers an event when the timer hits zero.
## 🔧 Features
- Customizable timer duration (in seconds)
- Live countdown display via Unity `Text` UI
- Triggers logic when timer finishes
- Easy to extend with events, animations, or sounds
## 🛠 How to Use
1. Add the script to a GameObject with a UdonBehaviour.
2. Set your desired `timerDuration` (e.g., 30 seconds).
3. Assign a Unity `Text` element to `timerText` in the inspector.
4. Call `StartTimer()` from a button, collider, or another script to begin the countdown.
## 🖥 Example Output
If `timerDuration = 90`, it will count down like:
```
01:30  
01:29  
...  
00:00
```
## 🚀 Extend This With:
- VRC button events (`Interact()` to start/reset)
- Trigger animations or teleportation when done
- Add synced timers using VRC networking (VRCPlayerApi & synced variables)
## 👤 Author
Created for VRChat by [@veyzohh](https://github.com/veyzohh)
