# PCA_ConsoleWriter
Simple Command Line Animator

Note: So far I’ve only created a few single-line animations. Have not yet ventured to create elaborate multi-line animations.

<b>Settings</b>

Variables:
- AniTextColorExplicit = Set color of current character being animated.
- TextColorExplicit = Set color of text before/after animation.
- BackgroundColor = Set background color of line.
- GarbledCharacterString = String of characters used in the Garbled animations.

Animation Types:
- Linear = Display each character at a time from left to right.
- GarbledRandom = Garbled characters that randomly change to text.
- GarbledLinear = Garbled characters that change to text from left to right.
- SlideIn = Characters slide into place from the right side of the screen.
<br>
<b>Functions</b>

        WriteAnimated(string text, int speed = 100, ConsoleColor? textColor = null, ConsoleColor? animationColor = null, AnimationType aniType = AnimationType.Linear)
        WriteLineAnimated(string text, int speed = 100, ConsoleColor? textColor = null, ConsoleColor? animationColor = null, AnimationType aniType = AnimationType.Linear)
        WriteLineAnimated(string[] text, int speed = 100, ConsoleColor?[] textColor = null, ConsoleColor?[] animationColor = null, AnimationType aniType = AnimationType.Linear)

WriteAnimated
- text = Text (string)
- speed = Animation speed (int)
- textColor = Line text color (ConsoleColor)
- animationColor = Color of animated character (ConsoleColor)
- aniType = Custom animation type (AnimationType)

WriteLineAnimated
- text = Line text (string or string[])
- speed = Animation speed (int)
- textColor = Line text color (ConsoleColor or ConsoleColor[])
  - If using array, the textColor array location will match the string array location
- animationColor = Color of animated character (ConsoleColor or ConsoleColor[])
  - If using array, the animationColor array location will match the string array location
- aniType = Custom animation type (AnimationType)

<br>

        using ConsoleWriter cw = new ConsoleWriter();
        cw.WriteLineAnimated("Animate this line.");
